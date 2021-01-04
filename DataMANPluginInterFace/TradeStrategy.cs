using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData;
using FinancialData.AlphaVantage;
using DataMAN.Options;

namespace DataMAN
{
    public interface ITradeStrategy
    {
        string Name { get; }
        Task<TradeResult> Trade(DateTime startDate, DateTime endDate , double cash);
    }

    public struct TradeResult
    {
        public double Cash;

    }
}
