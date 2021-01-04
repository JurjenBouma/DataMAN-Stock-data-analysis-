using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using DataMAN;

namespace FinancialData
{
    public static class StockDataBase
    {
        private static List<StockData> dataBase;
        private static TimeSpan _dataRefreshRate;

        public static void Initialize(TimeSpan StockDataRefreshRate)
        {
            dataBase = new List<StockData>();
            _dataRefreshRate = StockDataRefreshRate;
        }


        public static async Task<StockData> Get(Stock stock, Api.Interval interval, TimeSpan updateSpan)
        {
            StockData stockData;
            if (!Contains(stock, interval))
            {
                stockData = await stock.LoadStockData(interval, updateSpan);
                AddStockData(stockData);
            }
            else
            {
                stockData = GetStockData(stock, interval);
                DateTime lastRefeshed;
                try
                {
                    lastRefeshed = DateTime.Parse(stockData.MetaData.LastRefreshed);
                }
                catch
                {
                    lastRefeshed = DateTime.MinValue;
                }

                if (DateTime.UtcNow - lastRefeshed > updateSpan)
                {
                    stockData = await stock.LoadStockData(interval, updateSpan);
                    ReplaceStockData(stockData);
                }
            }

            return stockData;

        }

        public static async Task<StockData> Get(Stock stock, Api.Interval interval)
        {
            StockData stockData = await Get(stock, interval, _dataRefreshRate);
            return stockData;
        }

        private static void ReplaceStockData(StockData data)
        {
            if (data != null)
            {
                for (int i = 0; i < dataBase.Count; i++)
                {
                    if (data.MetaData.Symbol == dataBase[i].MetaData.Symbol)
                    {
                        if (data.MetaData.Interval == dataBase[i].MetaData.Interval)
                        {
                            dataBase.RemoveAt(i);
                            dataBase.Add(data);
                        }
                    }
                }
            }
        }

        private static void AddStockData(StockData data)
        {
            if (data != null && !dataBase.Contains(data))
            {
                dataBase.Add(data);
                if (dataBase.Count > 20)
                    RemoveStockData(0);
            }
        }

        private static void RemoveStockData(int index)
        {
            if (index < dataBase.Count)
            {
                dataBase.RemoveAt(index);
            }
        }

        private static StockData GetStockData(Stock stock, Api.Interval interval)
        {
            foreach (StockData data in dataBase)
            {
                if (data.MetaData.Symbol.Equals(stock.StockSymbol, StringComparison.OrdinalIgnoreCase))
                {
                    if (data.MetaData.Interval == interval)
                        return data;
                }
            }
            return null;
        }

        private static bool Contains(Stock stock, Api.Interval interval)
        {
            foreach (StockData data in dataBase)
            {
                if (data.MetaData.Symbol.Equals(stock.StockSymbol, StringComparison.OrdinalIgnoreCase))
                {
                    if (data.MetaData.Interval == interval)
                        return true;
                }
            }
            return false;
        }

    }
}
