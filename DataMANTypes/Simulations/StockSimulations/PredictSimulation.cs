using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData;

namespace DataMAN
{
    public class PredictSimulation
    {
        public string Name { get { return _name; } }
        public double RightPredictPercentage { get { return _rightPredictPercentage; } }
        public int TradesMade { get { return _tradesMade; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _endDate; } }

        private string _name;
        private double _rightPredictPercentage;
        private int _tradesMade;
        private DateTime _startDate;
        private DateTime _endDate;

        public PredictSimulation(string name, DateTime startDate, DateTime endDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
            _rightPredictPercentage = 1.0;
            _tradesMade = 0;
        }

        public async void Run(StockTradeList tradeList)
        {
            if (tradeList != null && tradeList.Trades.Count > 0)
            {
                //find all stocks traded
                StockList stocks = new StockList("TradeList");
                foreach (StockTrade trade in tradeList.Trades)
                {
                    stocks.Add(trade.Stock);
                }

                //find DataRange
                StockData firstData = await StockDataBase.Get(stocks.GetStock(0), tradeList.Interval);
                int startIndex = firstData.FindDateIndex( _startDate);
                int stopIndex = firstData.FindDateIndex( _endDate);
                int dataCount = firstData.TimeSeries.DataPoints.Count;

                if (stopIndex == 0)
                    stopIndex = dataCount - 1;

                //Simulate trades
                double timesTraded = 0;
                double timesRight = 0;
                StockTrade currentTrade = new StockTrade();
                StockData data = firstData;
                for (int i = startIndex; i <= stopIndex; i++)
                {
                    foreach (StockTrade trade in tradeList.Trades)
                    {
                        if (trade.DataIndex == i)
                        {
                            if (trade.PortfolioPercentage > 0)
                            {
                                data = await StockDataBase.Get(trade.Stock, tradeList.Interval);
                                currentTrade = trade;
                            }
                            else
                            {
                                timesTraded++;
                                double openPrice = data.TimeSeries.DataPoints[currentTrade.DataIndex].Close;
                                double closePrice = data.TimeSeries.DataPoints[i].Close;

                                if (currentTrade.Type == StockTradeType.LongStock && closePrice > openPrice)
                                    timesRight++;
                                if (currentTrade.Type == StockTradeType.ShortStock && closePrice < openPrice)
                                    timesRight++;
                            }
                        }
                    }
                }

                //save results
                _rightPredictPercentage = timesRight / timesTraded;
                _tradesMade = (int)timesTraded;
            }
        }
    }
}
