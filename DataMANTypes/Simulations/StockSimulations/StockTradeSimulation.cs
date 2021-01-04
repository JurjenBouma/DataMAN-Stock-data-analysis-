using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData;

namespace DataMAN
{
    public class StockTradeSimulation
    {
        public string Name { get { return _name; } }
        public double[] BalanceChart { get { return _balanceChart; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _endDate; } }

        private string _name;
        private double[] _balanceChart;
        private DateTime _startDate;
        private DateTime _endDate;

        public StockTradeSimulation(string name, double Balance , DateTime startDate, DateTime endDate )
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;

            _balanceChart = new double[1];
            _balanceChart[0] = Balance;
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
                int startIndex = firstData.FindDateIndex(_startDate);
                int stopIndex = firstData.FindDateIndex(_endDate);
                int dataCount = firstData.TimeSeries.DataPoints.Count;
              
                if (stopIndex == 0)
                    stopIndex = dataCount -1;

                //Simulate trades
                double startBalance = _balanceChart[0];
                StockPortfolio portfolio = new StockPortfolio(startBalance);
                List<double> balanceChartList = new List<double>();
                balanceChartList.Add(startBalance);

                for (int i = startIndex; i <= stopIndex; i++)
                {
                    foreach (StockTrade trade in tradeList.Trades)
                    {
                        if (trade.DataIndex == i)
                            portfolio.MakeTrade(trade, tradeList.Interval);
                    }
                    balanceChartList.Add(await portfolio.TotalBalance(i, tradeList.Interval));
                }
                _balanceChart = balanceChartList.ToArray();
            }
        }
    }
}
