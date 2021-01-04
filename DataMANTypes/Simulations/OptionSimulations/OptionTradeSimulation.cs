using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData;
using DataMAN.Options;

namespace DataMAN
{
    public class OptionTradeSimulation
    {
        public string Name { get { return _name; } }
        public GraphData BalanceChart { get { return _balanceChart; } }
        public DateTime StartDate { get { return _startDate; } }
        public DateTime EndDate { get { return _endDate; } }

        private string _name;
        private GraphData _balanceChart;
        private DateTime _startDate;
        private DateTime _endDate;
        private double _startBalance;
        private double _fee;
        private double _slippage;

        public OptionTradeSimulation(string name, double Balance , DateTime startDate, DateTime endDate)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
            _startBalance = Balance;
            _fee = 0;
            _slippage = 0;
        }

        public OptionTradeSimulation(string name, double Balance, DateTime startDate, DateTime endDate,double fee,double slippage)
        {
            _name = name;
            _startDate = startDate;
            _endDate = endDate;
            _startBalance = Balance;
            _fee = fee;
            _slippage = slippage;
        }

        public async void Run(OptionTradeList tradeList)
        {
            if (tradeList != null && tradeList.Trades.Count > 0)
            {
                //find DataRange
                StockData firstData = await StockDataBase.Get(tradeList.Stock, tradeList.Interval);
                int startIndex = firstData.FindDateIndex(_startDate);
                int stopIndex = firstData.FindDateIndex(_endDate);
                int dataCount = firstData.TimeSeries.DataPoints.Count;
              
                if (stopIndex == 0)
                    stopIndex = dataCount -1;

                //Simulate trades
                OptionPortfolio portfolio = new OptionPortfolio(_startBalance,_fee,_slippage);
                _balanceChart = new GraphData(_name + " Balance");

                for (int i = startIndex; i <= stopIndex; i++)
                {
                    foreach (OptionTrade trade in tradeList.Trades)
                    {
                        int dateIndex = firstData.FindDateIndex(trade.TradeDate);
                        if (dateIndex == i)
                            portfolio.MakeTrade(trade, tradeList.Interval);
                    }
                    DateTime date = firstData.TimeSeries.DataPoints[i].DateTime;
                    GraphDataPoint balanceGraphDataPoint = new GraphDataPoint(date, await portfolio.TotalBalance(date, tradeList.Interval));
                    _balanceChart.DataPoints.Add(balanceGraphDataPoint);
                }
            }
        }
    }
}
