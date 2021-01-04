using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using System.IO;
using FinancialData;
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    namespace Options
    {
        public enum SpreadType
        {
            LongCall, LongPut, ShortPut,
            LongCallVertical, ShortCallVertical, LongPutVertical, ShortPutVertical
        }

        public class Spread
        {
            public SpreadType Type { get { return _type; } }
            public Option[] Options { get { return _options; } }
            public Stock Stock { get { return _options[0].Stock; } }
            public DateTime ExpirationDate { get { return _options[0].ExpirationDate; } }

            private SpreadType _type;
            private Option[] _options;

            public Spread(Option[] options)
            {
                SetType(options);
                _options = options;
            }

            public static bool operator ==(Spread s1, Spread s2)
            {
                if ((object)s1 == null)
                    return (object)s2 == null;

                return s1.Equals(s2);

            }
            public static bool operator !=(Spread s1, Spread s2)
            {

                return !(s1 == s2);
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                    return false;

                Spread compareSpread = (Spread)obj;
                if (compareSpread.Stock.StockSymbol == Stock.StockSymbol && compareSpread._type == _type &&
                  compareSpread.ExpirationDate == ExpirationDate && compareSpread.HighStike == HighStike &&
                  compareSpread.LowStike == LowStike)
                    return true;
                return false;
            }

            public override int GetHashCode()
            {
                return base.GetHashCode();
            }

            private void SetType(Option[] options)
            {
                if (options.Length == 1)
                {
                    if (options[0].OptionType == OptionType.Call)
                    {
                        if (options[0].PositionType == PositionType.Long)
                            _type = SpreadType.LongCall;
                    }
                    else if (options[0].OptionType == OptionType.Put)
                    {
                        if (options[0].PositionType == PositionType.Long)
                            _type = SpreadType.LongPut;
                        if (options[0].PositionType == PositionType.Short)
                            _type = SpreadType.ShortPut;
                    }

                }
                else if ((options.Length == 2))
                {
                    if (options[1].Strike == 0)
                    {
                        if (options[0].OptionType == OptionType.Call)
                        {
                            if (options[0].PositionType == PositionType.Long)
                                _type = SpreadType.LongCall;
                        }
                        else if (options[0].OptionType == OptionType.Put)
                        {
                            if (options[0].PositionType == PositionType.Long)
                                _type = SpreadType.LongPut;
                            if (options[0].PositionType == PositionType.Short)
                                _type = SpreadType.ShortPut;
                        }
                    }
                    else
                    {
                        if (options[0].OptionType == OptionType.Call)
                        {
                            int highStikeIndex = options[0].Strike > options[1].Strike ? 0 : 1;
                            if (options[highStikeIndex].PositionType == PositionType.Long)
                                _type = SpreadType.ShortCallVertical;
                            else
                                _type = SpreadType.LongCallVertical;
                        }
                        else if (options[0].OptionType == OptionType.Put)
                        {
                            int highStikeIndex = options[0].Strike > options[1].Strike ? 0 : 1;
                            if (options[highStikeIndex].PositionType == PositionType.Long)
                                _type = SpreadType.LongPutVertical;
                            else
                                _type = SpreadType.ShortPutVertical;
                        }
                    }
                }
            }

            public double LowStike
            { get
                {
                    double result = 0;
                    if (_options.Length > 1)
                        result = _options[0].Strike < _options[1].Strike ? _options[0].Strike : _options[1].Strike;
                    else
                        result = _options[0].Strike;

                    if (result == 0)
                        result = HighStike;

                    return result;
                }
            }

            public double HighStike
            { get
                {
                    if (_options.Length > 1)
                        return _options[0].Strike > _options[1].Strike ? _options[0].Strike : _options[1].Strike;
                    else
                        return _options[0].Strike;
                }
            }

            public async Task<double> PositionValue(DateTime date , int quantity)
            {
                double posValue = 0;
                double price = await Price(date);

                if (_type == SpreadType.LongCall || _type == SpreadType.LongCallVertical
                    || _type == SpreadType.LongPut || _type == SpreadType.LongPutVertical)
                {
                    posValue = price * 100 * quantity;
                }
                else if (_type == SpreadType.ShortCallVertical
                    || _type == SpreadType.ShortPutVertical || _type == SpreadType.ShortPut)
                {
                    double maxValue = MaxValue();
                    posValue = (maxValue - (price * 100)) * quantity;
                }

                return posValue;
            }

            public async Task<double> Cost(DateTime date)
            {
                double cost = 0;
                double price = await Price(date);

                if (_type == SpreadType.LongCall || _type == SpreadType.LongCallVertical
                    || _type == SpreadType.LongPut || _type == SpreadType.LongPutVertical)
                {
                    cost = -price;
                }
                else if (_type == SpreadType.ShortCallVertical
                    || _type == SpreadType.ShortPutVertical || _type == SpreadType.ShortPut)
                {
                    cost = price;
                }

                return cost;
            }

            public async Task<double> Price(DateTime date)
            {
                double[] prices = new double[_options.Length];
                for (int i = 0; i < _options.Length; i++)
                {
                    prices[i] = await _options[i].Price(date);
                }
                double price = prices[0];

                if(_type == SpreadType.LongCallVertical || _type == SpreadType.LongPutVertical || 
                    _type == SpreadType.ShortCallVertical || _type == SpreadType.ShortPutVertical)
                {
                    price = Math.Abs(prices[0] - prices[1]);
                }

                return price;
            }

            public double MaxValue()
            {
                double maxValue = 0;

                if (_type == SpreadType.LongCallVertical || _type == SpreadType.LongPutVertical ||
                   _type == SpreadType.ShortCallVertical || _type == SpreadType.ShortPutVertical)
                {
                    maxValue = Math.Abs(_options[0].Strike - _options[1].Strike) * 100;
                }
                else if (_type == SpreadType.ShortPut || _type == SpreadType.LongPut)
                {
                    maxValue = _options[0].Strike * 100;
                }
                else if (_type == SpreadType.LongCall)
                {
                    maxValue = 9999999999;
                }


                return maxValue;
            }

            public async Task<double> MaxProfit(DateTime date)
            {
                double maxProfit = 0;

                double price = await Price(date);
                double maxValue = MaxValue();

                if (_type == SpreadType.LongPutVertical || _type == SpreadType.LongCallVertical 
                    || _type == SpreadType.LongPut || _type == SpreadType.LongCall)
                {
                    maxProfit = maxValue - (price*100);
                }
                else if (_type == SpreadType.ShortCallVertical || _type == SpreadType.ShortPutVertical 
                    || _type == SpreadType.ShortPut)
                {
                    maxProfit = price * 100;
                }

                return maxProfit;
            }

            public async Task<double> MaxLoss(DateTime date)
            { 
                double maxValue = MaxValue();
                double maxProfit = await MaxProfit(date);

                return maxValue - maxProfit;
            }

            public async Task<double> BreakEven(DateTime date)
            {
                double price = await Price(date);
                double result = 0;

                if (_type == SpreadType.LongCall || _type == SpreadType.LongCallVertical || _type == SpreadType.ShortCallVertical)
                {
                    result = LowStike + price;
                }
                else if (_type == SpreadType.LongPut || _type == SpreadType.ShortPut)
                {
                    result = LowStike - price;
                }
                else if (_type == SpreadType.LongPutVertical || _type == SpreadType.ShortPutVertical)
                {
                    result = HighStike - price;
                }
                return result;
            }

            public int ProfitDirection
            {
                get
                {
                    int result = 0;

                    if (_type == SpreadType.LongCall || _type == SpreadType.LongCallVertical || _type == SpreadType.ShortPutVertical || _type == SpreadType.ShortPut)
                    {
                        result = 1;
                    }
                    else if (_type == SpreadType.LongPut || _type == SpreadType.ShortCallVertical || _type == SpreadType.LongPutVertical)
                    {
                        result = -1;
                    }
                    return result;
                }
            }

            public int DaysUntilExpiration(DateTime date)
            {
                int days = _options[0].DaysUntilExpiration(date);
                return days;
            }

            public static Spread GetSpread(Stock stock, SpreadType type, double strikeLow, double spreadWidth, DateTime experationDate, DateTime date)
            {
                Option[] options;
                if (type == SpreadType.LongCall || type == SpreadType.LongPut || type == SpreadType.ShortPut)
                    options = new Option[1];
                else
                    options = new Option[2];

                switch (type)
                {
                    case SpreadType.LongCall:
                        options[0] = Option.GetOption(stock, OptionType.Call, PositionType.Long, strikeLow, experationDate , date);
                        break;
                    case SpreadType.LongPut:
                        options[0] = Option.GetOption(stock, OptionType.Put, PositionType.Long, strikeLow, experationDate, date);
                        break;
                    case SpreadType.ShortPut:
                        options[0] = Option.GetOption(stock, OptionType.Put, PositionType.Short, strikeLow, experationDate, date);
                        break;
                    case SpreadType.LongCallVertical:
                        options[0] = Option.GetOption(stock, OptionType.Call, PositionType.Long, strikeLow, experationDate, date);
                        options[1] = Option.GetOption(stock, OptionType.Call, PositionType.Short, strikeLow + spreadWidth, experationDate, date);
                        break;
                    case SpreadType.ShortCallVertical:
                        options[0] = Option.GetOption(stock, OptionType.Call, PositionType.Short, strikeLow, experationDate, date);
                        options[1] = Option.GetOption(stock, OptionType.Call, PositionType.Long, strikeLow + spreadWidth, experationDate, date);
                        break;
                    case SpreadType.LongPutVertical:
                        options[0] = Option.GetOption(stock, OptionType.Put, PositionType.Short, strikeLow, experationDate, date);
                        options[1] = Option.GetOption(stock, OptionType.Put, PositionType.Long, strikeLow + spreadWidth, experationDate, date);
                        break;
                    case SpreadType.ShortPutVertical:
                        options[0] = Option.GetOption(stock, OptionType.Put, PositionType.Long, strikeLow, experationDate, date);
                        options[1] = Option.GetOption(stock, OptionType.Put, PositionType.Short, strikeLow + spreadWidth, experationDate, date);
                        break;
                }

                if(options.Length == 2)
                {
                    if (options[0].Strike == options[1].Strike)
                    {
                        OptionChain chain = OptionDataBase.Get(options[1].Stock, date);
                        double newStrike = chain.FindNextStrike(options[1].Strike, options[1].ExpirationDate); 
                        options[1] = Option.GetOption(options[1].Stock, options[1].OptionType, options[1].PositionType,
                          newStrike, options[1].ExpirationDate, date); 
                    }
                }

                Spread spread = new Spread(options);
                return spread;
            }
        }
    }
}
