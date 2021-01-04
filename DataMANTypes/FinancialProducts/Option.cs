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
        public enum OptionType
        {
            Call, Put
        }

        public enum PositionType
        {
            Long, Short
        }

        public class Option
        {
            public Stock Stock { get { return _stock; } }
            public OptionType OptionType { get { return _optionType; } }
            public PositionType PositionType { get { return _positionType; } }
            public double Strike { get { return _strike; } }
            public DateTime ExpirationDate { get { return _expDate; } }

            private Stock _stock;
            private OptionType _optionType;
            private PositionType _positionType;
            private double _strike;
            private DateTime _expDate;

            public Option(Stock stock, OptionType optionType, PositionType positionType, double strike, DateTime expirationDate)
            {
                _stock = stock;
                _optionType = optionType;
                _positionType = positionType;
                _strike = strike;
                _expDate = expirationDate;
            }

            public bool HistoricData(DateTime date)
            {
                OptionChain chain = OptionDataBase.Get(_stock, date);
                if (chain != null)
                {
                    return true;
                }
                return false;
            }

            public async Task<double> Price(DateTime date)
            {
                double price = 0;
                OptionChain chain = OptionDataBase.Get(_stock, date);
                if (chain != null)
                {
                    OptionChainDataPoint option = chain.FindOption(_optionType, _expDate, _strike);
                    price = (option.Bid + option.Ask) * 0.5;
                }
                else
                {
                    TimeSpan updateSpan = DateTime.UtcNow - date;
                    StockData data = await StockDataBase.Get(_stock, Api.Interval.Daily, updateSpan);
                    int index = data.FindDateIndex(date);
                    int expiration = DaysUntilExpiration(date);
                    price = Indicators.Options.AproxPrice(data, index, _optionType, _strike, expiration);
                }
                return price;
            }

            public int DaysUntilExpiration(DateTime date)
            {
                TimeSpan difference = _expDate - date;
                return difference.Days;
            }

            public static Option GetOption(Stock stock, OptionType optionType , PositionType posType, double strike, DateTime experation, DateTime date)
            {
                OptionChain chain = OptionDataBase.Get(stock, date);

                if (chain != null)
                {
                    OptionChainDataPoint option = chain.FindOption(optionType, experation, strike);
                    return new Option(stock, option.Type, posType, option.Strike, option.Experation);
                }
                else
                {
                    int daysUntilThursday = 4 - (int)experation.DayOfWeek;
                    experation = experation.AddDays(daysUntilThursday);

                    strike = Math.Round(strike, 0);
                    double amountFromTwoFifty = (strike % 2.5) <= (2.5 - strike % 2.5) ? -(strike % 2.5) : (2.5 - strike % 2.5);
                    strike += amountFromTwoFifty;

                    return new Option(stock, optionType, posType, strike, experation);
                }
            }

            public static OptionType ParseType(string typeString)
            {
                if (typeString.ToLower() == "call")
                    return OptionType.Call;
                else
                    return OptionType.Put;
            }
        }
    }
}
