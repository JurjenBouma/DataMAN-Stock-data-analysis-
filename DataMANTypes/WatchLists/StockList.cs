using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinancialData.AlphaVantage;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DataMAN
{
    public class StockList
    {
        public string Name;
        public string[] Stocks { get { return GetStockNames(); } }

        private List<Stock> _stocks;

        public StockList(string name)
        {
            Name = name;
            _stocks = new List<Stock>();
        }

        private string[] GetStockNames()
        {
            string[] stocks = new string[_stocks.Count];
            for(int i =0; i< _stocks.Count;i++)
            {
                stocks[i] = _stocks[i].StockSymbol;
            }
            return stocks;
        }

        public void Add(string stock)
        {
            if (!ContainsStock(stock))
            {
                Stock stockItem = new Stock(stock);
                _stocks.Add(stockItem);   
            }
        }

        public void Add(Stock stock)
        {
            if (!ContainsStock(stock.StockSymbol))
            {
                _stocks.Add(stock);
            }
        }

        public void Remove(int index)
        {
            if (_stocks.Count > index)
                  _stocks.RemoveAt(0);
        }

        public void Remove(string stock)
        {
            for (int i = 0; i < _stocks.Count; i++)
            {
                if (_stocks[i].StockSymbol.Equals(stock, StringComparison.OrdinalIgnoreCase))
                    _stocks.RemoveAt(i);
            }
        }

        public Stock GetStock(int index)
        {
            if (index < _stocks.Count)
                return _stocks[index];
            else
                return null;

        }

        public Stock GetStock(string stock)
        {
            for (int i = 0; i < _stocks.Count; i++)
            {
                if (_stocks[i].StockSymbol.Equals(stock,StringComparison.OrdinalIgnoreCase))
                    return _stocks[i];
            }
            return null;
        }

        public void Save()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\WatchLists\\"
                 + Name + ".json";
            string json = JsonConvert.SerializeObject(_stocks);

            FileInfo file = new FileInfo(filePath);
            if (!Directory.Exists(file.DirectoryName))
                Directory.CreateDirectory(file.DirectoryName);
            StreamWriter stream = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
            stream.Write(json);
            stream.Close();
        }

        public void DeleteFile()
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\WatchLists\\"
                + Name + ".json";

            FileInfo file = new FileInfo(filePath);
            if(file.Exists)
                file.Delete();
        }

        public void Load(string fileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\WatchLists\\"
                + fileName;

            if (File.Exists(filePath))
            { 
                Name = fileName.Split('.')[0];
                List<Stock> temp = JsonConvert.DeserializeObject<List<Stock>>(File.ReadAllText(filePath));
                if(temp != null)
                    _stocks = temp;
            }
        }

        public bool ContainsStock(string stock)
        {
            foreach(Stock item in _stocks)
            {
                if (item.StockSymbol.Equals(stock, StringComparison.OrdinalIgnoreCase))
                    return true;
            }
            return false;
        }
    }
}
