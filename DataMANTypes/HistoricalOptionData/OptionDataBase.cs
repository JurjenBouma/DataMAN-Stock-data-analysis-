using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using FinancialData.HistoricalOptionData;
using DataMAN;

namespace FinancialData
{
    public static class OptionDataBase
    {
        private static List<OptionChain> dataBase;

        public static void Initialize()
        {
            dataBase = new List<OptionChain>();
        }

        public static OptionChain Get(Stock stock, DateTime dataDate)
        {
            OptionChain optionChain;
            if (!Contains(stock, dataDate))
            {
                optionChain = OptionChain.LoadChainFromFile(stock, dataDate);
                if(optionChain != null)
                    AddChain(optionChain);
            }
            else
            {
                optionChain = GetChain(stock, dataDate);
            }

            return optionChain;
        }

        private static void ReplaceChain(OptionChain chain)
        {
            if (chain != null)
            {
                for (int i = 0; i < dataBase.Count; i++)
                {
                    if (chain.Stock.StockSymbol == dataBase[i].Stock.StockSymbol)
                    {
                        if (chain.DataDate == dataBase[i].DataDate)
                        {
                            dataBase.RemoveAt(i);
                            dataBase.Add(chain);
                        }
                    }
                }
            }
        }

        private static void AddChain(OptionChain chain)
        {
            if (chain != null && !dataBase.Contains(chain))
            {
                dataBase.Add(chain);
                if (dataBase.Count > 20)
                    RemoveChain(0);
            }
        }

        private static void RemoveChain(int index)
        {
            if (index < dataBase.Count)
            {
                dataBase.RemoveAt(index);
            }
        }

        private static OptionChain GetChain(Stock stock, DateTime dataDate)
        {
            foreach (OptionChain chain in dataBase)
            {
                if (chain.Stock.StockSymbol.Equals(stock.StockSymbol, StringComparison.OrdinalIgnoreCase))
                {
                    if (chain.DataDate == dataDate)
                        return chain;
                }
            }
            return null;
        }

        private static bool Contains(Stock stock, DateTime dataDate)
        {
            foreach (OptionChain chain in dataBase)
            {
                if (chain.Stock.StockSymbol.Equals(stock.StockSymbol, StringComparison.OrdinalIgnoreCase))
                {
                    if (chain.DataDate == dataDate)
                        return true;
                }
            }
            return false;
        }

    }
}

