using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData;

namespace DataMAN
{
    public class StockPosition
    {
        public Stock Stock;
        public int Amount;
        public StockTradeType Type;
        public int EntryIndex;
    }

    public class StockPortfolio
    {
        public double Cash;
        public List<StockPosition> Positions;

        public StockPortfolio(double cash)
        {
            Cash = cash;
            Positions = new List<StockPosition>();
        }

        public void MakeTrade(StockTrade trade, Api.Interval interval)
        {
            if (trade.Stock != null)
            {
                ClosePosition(trade, interval);
                OpenPosition(trade, interval);
            }
        }
        private async void OpenPosition(StockTrade trade, Api.Interval interval)
        {
            StockData data = await StockDataBase.Get(trade.Stock, interval);
            StockPosition position = GetPosition(trade.Stock);
            double totalBalance = await TotalBalance(trade.DataIndex, interval);

            position.EntryIndex = trade.DataIndex;
            double entryPrice = data.TimeSeries.DataPoints[trade.DataIndex].Close;
            double budget = totalBalance * trade.PortfolioPercentage;
            position.Amount = (int)(budget / entryPrice);
            position.Type = trade.Type;//long or short
            Cash -= position.Amount * entryPrice;
        }

        private async void ClosePosition(StockTrade trade, Api.Interval interval)
        {
            StockData data = await StockDataBase.Get(trade.Stock, interval);
            StockPosition position = GetPosition(trade.Stock);
            double posValue = GetPositionValue(position, data, trade.DataIndex);
            position.Amount = 0;
            Cash += posValue;
        }

        private double GetPositionValue(StockPosition position, StockData data, int dataIndex)
        {
            double posValue;
            double entryPrice = data.TimeSeries.DataPoints[position.EntryIndex].Close;

            if (position.Type == StockTradeType.LongStock)
                posValue = data.TimeSeries.DataPoints[dataIndex].Close * position.Amount;
            else
                posValue = (entryPrice + entryPrice - data.TimeSeries.DataPoints[dataIndex].Close) * position.Amount;
            return posValue;
        }

        public async Task<double> TotalBalance(int dataIndex, Api.Interval interval)
        {
            double total = Cash;
            foreach (StockPosition position in Positions)
            {
                StockData data = await StockDataBase.Get(position.Stock, interval);
                total += GetPositionValue(position, data, dataIndex);
            }
            return total;
        }

        private StockPosition GetPosition(Stock stock)
        {
            if (stock != null)
            {
                for (int i = 0; i < Positions.Count; i++)
                {
                    if (Positions[i].Stock.StockSymbol == stock.StockSymbol)
                        return Positions[i];
                }
            }
            StockPosition newPos = new StockPosition();
            newPos.Stock = stock;
            Positions.Add(newPos);
            return Positions[Positions.Count-1];
        }
    }
}
