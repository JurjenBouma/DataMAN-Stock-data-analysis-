using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FinancialData.AlphaVantage;


namespace DataMAN
{
    public class WatchLists
    {
        public string[] Lists { get { return GetListNames(); } }
        public int Count { get { return _stockLists.Count; } }

        private List<StockList> _stockLists;

        public WatchLists()
        {
            _stockLists = new List<StockList>();
        }

        public StockList Get(string name)
        {
            foreach(StockList list in _stockLists)
            {
                if (list.Name == name)
                    return list;
            }
            return null;
        }

        public void Add(StockList list)
        {
            if(list != null && !Contains(list.Name))
            {
                _stockLists.Add(list);
            }
        }

        public void DeleteFile(string list)
        {
            for (int i = 0; i < _stockLists.Count; i++)
            {
                if (_stockLists[i].Name == list)
                    _stockLists[i].DeleteFile();
            }
        }

        public void Remove(string list)
        {
            for (int i = 0; i < _stockLists.Count; i++)
            {
                if (_stockLists[i].Name == list)
                    _stockLists.RemoveAt(i);
            }
        }

        public void Remove(StockList list)
        {
            Remove(list.Name);
        }

        public void SaveAll()
        {
            foreach (StockList list in _stockLists)
            {
                list.Save();
            }
        }

        public void Load()
        {
            string listDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\WatchLists";

            if (Directory.Exists(listDirectory))
            {
                foreach(string file in Directory.GetFiles(listDirectory))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    if(fileInfo.Extension == ".json")
                    {
                        StockList stockList = new StockList(fileInfo.Name);
                        stockList.Load(fileInfo.Name);
                        _stockLists.Add(stockList);
                    }
                }
            }
        }

        public bool Contains(string name)
        {
            foreach (StockList list in _stockLists)
            {
                if (list.Name == name)
                    return true;
            }
            return false;
        }

        private string[] GetListNames()
        {
            string[] names = new string[_stockLists.Count];
            for (int i = 0; i < _stockLists.Count; i++)
            {
                names[i] = _stockLists[i].Name;
            }
            return names;
        }
    }
}
