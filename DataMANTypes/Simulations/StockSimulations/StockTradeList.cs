using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData;

namespace DataMAN
{
    public enum StockTradeType
    {
        LongStock, ShortStock
    }

    public struct StockTrade
    {
        public StockTradeType Type;
        public double PortfolioPercentage;
        public int DataIndex;
        public Stock Stock;
    }

    public class StockTradeList
    {
        public List<StockTrade> Trades;
        public Api.Interval Interval;

        public StockTradeList(Api.Interval interval)
        {
            Interval = interval;
            Trades = new List<StockTrade>();
        }
    }
}
