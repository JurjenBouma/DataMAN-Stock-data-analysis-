using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using System.IO;
using FinancialData;

namespace DataMAN
{
    public class Stock
    {
        public string StockSymbol { get { return _stockSymbol; } }
        //public double DailyChange;

        private string _stockSymbol;

        public Stock(string stockSymbol)
        {
            _stockSymbol = stockSymbol;
            if (_stockSymbol != null)
                _stockSymbol = _stockSymbol.ToUpper();
        }

        public async Task<StockData> LoadStockData(Api.Interval interval, TimeSpan dataRefreshTime)
        {

            StockData tempData = LoadStockDataFromFile(interval);

            DateTime lastRefeshed;
            try
            {
                lastRefeshed = DateTime.Parse(tempData.MetaData.LastRefreshed);
            }
            catch
            {
                lastRefeshed = DateTime.MinValue;
            }

            if (DateTime.UtcNow - lastRefeshed > dataRefreshTime)
                tempData = await DownloadStockData(interval);

            int tempDataCount = tempData.TimeSeries.DataPoints.Count;

            return tempData;
        }

        public StockData LoadStockDataFromFile(Api.Interval interval)
        {
            StockData stockData = new StockData();
            if (StockSymbol.Length > 0)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\Financial data\\Stocks\\"
                    + _stockSymbol + "\\" + interval.ToString() + "\\" + _stockSymbol + ".json";

                if (File.Exists(filePath))
                    stockData = JsonConverter.ConvertJsonFromFile(filePath);
            }
            return stockData;
        }

        public async Task<StockData> DownloadStockData(Api.Interval interval)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\Financial data\\Stocks\\"
                      + _stockSymbol + "\\" + interval.ToString() + "\\" + _stockSymbol + ".json";

            await Api.GetDataToFile(_stockSymbol, interval, Api.Outputsize.full, filePath);

            StockData stockData = LoadStockDataFromFile(interval);
            return stockData;
        }

        public async Task<double> Price(DateTime date)
        {
            double price = 0;
            TimeSpan updateSpan = DateTime.UtcNow - date;
            StockData data = await StockDataBase.Get(this, Api.Interval.Daily, updateSpan);
            if (data != null)
                price = data.TimeSeries.DataPoints[data.FindDateIndex(date)].Close;
            return price;
        }

       /* public async Task<double> Price(int dataIndex)
        {
            double price = 0;
            StockData data = await StockDataBase.Get(this, Api.Interval.Daily);
            if (data != null)
                price = data.TimeSeries.DataPoints[dataIndex].Close;
            return price;
        }*/
    }
}
