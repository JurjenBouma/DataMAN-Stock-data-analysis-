using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData;
using FinancialData.AlphaVantage;
using DataMAN.Options;
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    public class TrainerSimulation
    {
        public EventHandler NextDaySimulated;
        public EventHandler TradeMade;
        public StockData StockData { get { return _stockData; } }
        public DateTime SimulationDate { get { return _simDate; } }
        public double Cash { get { return _portfolio.Cash; } }
        public Stock Stock { get { return new Stock(_stockData.MetaData.Symbol); } }
        public List<OptionPosition> Positions { get { return _portfolio.Positions; } }

        private DateTime _simDate;
        private StockData _stockData;
        private OptionPortfolio _portfolio;
        private int _dataIndex;
        private List<OptionPortfolio> _portofolioHistory;

        public TrainerSimulation()
        {
        }

        public void Start(double cash, DateTime startDate, Stock stock)
        {
            _simDate = startDate;
            ChangeStock(stock);
            _portfolio = new OptionPortfolio(cash, 1.1, 0.04);
            _portfolio.TradeMade += new EventHandler(FireTradeMade);
            _portofolioHistory = new List<OptionPortfolio>();
        }

        public void MakeTrade(OptionTrade trade)
        {
            if (trade.Spread.Options[0] != null || trade.Spread.Options[0].Strike != 0)
            {
                if (trade.Spread.Options.Length == 2)
                {
                    if (trade.Spread.Options[0].Strike > 0 && trade.Spread.Options[1].Strike == 0)
                    {
                        if ((trade.Spread.Options[0].OptionType == OptionType.Call && trade.Spread.Options[0].PositionType == PositionType.Short))
                            return;

                        Option[] newSpreadOption = new Option[1];
                        newSpreadOption[0] = trade.Spread.Options[0];
                        trade.Spread = new Spread(newSpreadOption);
                    }
                }
                _portfolio.MakeTrade(trade, Api.Interval.Daily);
            }
        }

        public async Task<double> TotalBalance()
        {
            return await _portfolio.TotalBalance(_simDate);
        }

        public async void NextTradeDay()
        {
            _dataIndex++;
            TimeSpan updateSpan = DateTime.UtcNow - _simDate;
            StockData stockData = await StockDataBase.Get(Stock, Api.Interval.Daily, updateSpan);
            if (_dataIndex <= stockData.TimeSeries.DataPoints.Count)
            {
                _simDate = stockData.TimeSeries.DataPoints[_dataIndex].DateTime;
                if (OptionChain.DataAvailible(Stock, _simDate))
                {
                    ChangeStock(Stock);
                    _portofolioHistory.Add(new OptionPortfolio(_portfolio));
                    _portfolio.CloseExpiredPositions(_simDate);
                    NextDaySimulated?.Invoke(this, new EventArgs());
                }
            }
        }

        public async void RollBackOneDay()
        {
            if (_portofolioHistory.Count > 0)
            {
                _dataIndex--;
                TimeSpan updateSpan = DateTime.UtcNow - _simDate;
                StockData stockData = await StockDataBase.Get(Stock, Api.Interval.Daily, updateSpan);
                if (_dataIndex >= 0)
                {
                    _simDate = stockData.TimeSeries.DataPoints[_dataIndex].DateTime;

                    ChangeStock(Stock);
                    _portfolio = new OptionPortfolio(_portofolioHistory[_portofolioHistory.Count - 1]);
                    _portofolioHistory.RemoveAt(_portofolioHistory.Count - 1);
                    NextDaySimulated?.Invoke(this, new EventArgs());
                }
            }
        }

        public async void ChangeStock(Stock stock)
        {
            TimeSpan updateSpan = DateTime.UtcNow - _simDate;
            StockData stockData = await StockDataBase.Get(stock, Api.Interval.Daily, updateSpan);
            if (stockData.TimeSeries.DataPoints[0].DateTime <= _simDate)
            {
                _stockData = new StockData();
                _stockData.MetaData = stockData.MetaData;
                _dataIndex = stockData.FindDateIndex(_simDate);
                if(_dataIndex <= stockData.TimeSeries.DataPoints.Count)
                    _stockData.TimeSeries.DataPoints = stockData.TimeSeries.DataPoints.GetRange(0, _dataIndex +1);
            }
        }

        private void FireTradeMade(object sender, EventArgs e)
        {
            TradeMade?.Invoke(sender, e);
        }
    }
}
