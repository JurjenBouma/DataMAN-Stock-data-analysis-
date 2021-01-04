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
    public struct OptionTrade
    {
        public Spread Spread;
        public double PortfolioPercentage;
        public int Amount;
        public DateTime TradeDate;
    }

    public class OptionTradeList
    {
        public List<OptionTrade> Trades;
        public Api.Interval Interval;
        public Stock Stock;

        public OptionTradeList(Stock stock, Api.Interval interval)
        {
            Stock = stock;
            Interval = interval;
            Trades = new List<OptionTrade>();
        }
    }
}
