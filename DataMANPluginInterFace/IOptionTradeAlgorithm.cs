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
    public interface IOptionTradeAlgorithm
    {
        string Name { get; }
        Task<OptionTradeList> Find(Stock stock, DateTime startDate, DateTime endDate);
    }
}
