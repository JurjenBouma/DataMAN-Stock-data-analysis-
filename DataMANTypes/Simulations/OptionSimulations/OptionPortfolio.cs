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
    public class OptionPosition
    {
        public Spread Spread;
        public int Amount = 0;
        public DateTime EntryDate;
    }

    public class OptionPortfolio
    {
        public EventHandler TradeMade;
        public double Cash;
        public List<OptionPosition> Positions;
        public double Fee;
        public double Slippage;

        public OptionPortfolio(double cash)
        {
            Cash = cash;
            Positions = new List<OptionPosition>();
            Fee = 0;
            Slippage = 0;
        }

        public OptionPortfolio(double cash ,double fee,double slippage)
        {
            Cash = cash;
            Positions = new List<OptionPosition>();
            Fee = fee;
            Slippage = slippage;
        }

        public OptionPortfolio(OptionPortfolio original)
        {
            Cash = original.Cash;
            CopyPositions(original);
            Fee = original.Fee;
            Slippage = original.Slippage;
            TradeMade = original.TradeMade;
        }

        private void CopyPositions(OptionPortfolio original)
        {
            Positions = new List<OptionPosition>();
            foreach(OptionPosition pos in original.Positions)
            {
                OptionPosition newPos = new OptionPosition()
                {
                    Amount = pos.Amount,
                    Spread = pos.Spread,
                    EntryDate = pos.EntryDate
                };
                Positions.Add(newPos);
            }
        }

        public async void MakeTrade(OptionTrade trade, Api.Interval interval)
        {
            if (trade.Spread != null)
            {
                ClosePosition(trade, interval);
                bool x = await OpenPosition(trade, interval);
                TradeMade?.Invoke(this, new EventArgs());
            }
        }

        private async Task<bool> OpenPosition(OptionTrade trade, Api.Interval interval)
        {
            TimeSpan updateSpan = DateTime.UtcNow - trade.TradeDate;
            StockData data = await StockDataBase.Get(trade.Spread.Stock, interval, updateSpan);
            OptionPosition position = GetPosition(trade.Spread);
            position.Spread = trade.Spread;

            double totalBalance = await TotalBalance(trade.TradeDate, interval);

            position.EntryDate = trade.TradeDate;
            double margin = await trade.Spread.MaxLoss(trade.TradeDate);
            double budget = totalBalance * trade.PortfolioPercentage;
            if (trade.Amount == 0)
            {
                position.Amount = (int)(budget / (margin * (1 + Slippage) + Fee));
            }
            else
            {
                double totalCost = (margin * (1 + Slippage) + Fee) * trade.Amount;
                if (Cash >= totalCost)
                    position.Amount = trade.Amount;
                else
                {
                    position.Amount = 0;
                }
            }
            Cash -= position.Amount * (margin * (1 + Slippage) + Fee);
            return true;
        }

        private async void ClosePosition(OptionTrade trade, Api.Interval interval)
        {
            TimeSpan updateSpan = DateTime.UtcNow - trade.TradeDate;
            StockData data = await StockDataBase.Get(trade.Spread.Stock, interval, updateSpan);
            OptionPosition position = GetPosition(trade.Spread);
            double posValue = await GetPositionValue(position, data, trade.TradeDate);
            Cash += posValue * (1 - Slippage) - Fee * position.Amount;
            position.Amount = 0;
        }

        private async Task<double> GetPositionValue(OptionPosition position, StockData data, DateTime date)
        {
            double posValue = 0;
            if(position.Amount > 0)
                posValue = await position.Spread.PositionValue(date, position.Amount);

            return posValue;
        }

        public async Task<double> TotalBalance(DateTime dataDate)
        {
            double total = await TotalBalance(dataDate, Api.Interval.Daily);
            return total;
        }

        public async Task<double> TotalBalance(DateTime date, Api.Interval interval)
        {
            double total = Cash;
            foreach (OptionPosition position in Positions)
            {
                TimeSpan updateSpan = DateTime.UtcNow - date;
                StockData data = await StockDataBase.Get(position.Spread.Stock, interval, updateSpan);
                total += await GetPositionValue(position, data , date) * (1 - Slippage);
            }
            return total;
        }

        private OptionPosition GetPosition(Spread spread)
        {
            if (spread != null)
            {
                for (int i = 0; i < Positions.Count; i++)
                {
                    if (Positions[i].Spread == spread)
                        return Positions[i];
                }
            }
            OptionPosition newPos = new OptionPosition();
            newPos.Spread = spread;
            Positions.Add(newPos);
            return Positions[Positions.Count - 1];
        }

        public void CloseExpiredPositions(DateTime date)
        {
            foreach (OptionPosition position in Positions)
            {
                if (position.Spread.DaysUntilExpiration(date) <= 0)
                {
                    OptionTrade closeTrade = new OptionTrade()
                    {
                        Amount = 0,
                        TradeDate = date,
                        PortfolioPercentage = 0,
                        Spread = position.Spread
                    };
                    ClosePosition(closeTrade, Api.Interval.Daily);
                }
            }
        }
    }
}
