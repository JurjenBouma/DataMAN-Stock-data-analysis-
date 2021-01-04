using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMAN
{
    public static class WatchListManager
    {
        public static string[] WatchLists { get { return _watchLists.Lists; } }
        public static StockList RecentList { get { return _recentList; } }
        public delegate void ListCangedHandler();
        public static event ListCangedHandler ListChanged;

        private static WatchLists _watchLists;
        private static StockList _recentList;

        private static int maxRecentStocks = 10;

        public static void Initialize()
        {
            _watchLists = new WatchLists();
            _watchLists.Load();
            _watchLists.Remove("RecentlyUsed");

            _recentList = new StockList("RecentlyUsed");
            _recentList.Load("RecentlyUsed.json");
        }

        public static void Save()
        {
            _watchLists.SaveAll();
            _recentList.Save();
        }

        public static void AddToRecentList(Stock stock)
        {
            _recentList.Add(stock.StockSymbol);
            if (_recentList.Stocks.Length > maxRecentStocks)
                _recentList.Remove(0);
        }

        public static Stock GetFromRecentList(string stockName)
        { 
               return _recentList.GetStock(stockName);
        }

        public static StockList GetList(string listName)
        {
            return _watchLists.Get(listName);
        }

        public static void AddNewList(string listName)
        {
            StockList list = new StockList(listName);
            _watchLists.Add(list);

            if (ListChanged != null)
                ListChanged();
        }

        public static void RemoveList(string listName)
        {
            _watchLists.DeleteFile(listName);
            _watchLists.Remove(listName);
            if (ListChanged != null)
                ListChanged();
        }

        public static void AddToList(string listName,Stock stock)
        {
            _watchLists.Get(listName).Add(stock.StockSymbol);
           
            if (ListChanged != null)
                ListChanged();
        }

        public static void RemoveFromList(string listName, Stock stock)
        {
            _watchLists.Get(listName).Remove(stock.StockSymbol);

            if (ListChanged != null)
                ListChanged();
        }

        public static Stock GetFromList(string listName, string stockName)
        {
            return _watchLists.Get(listName).GetStock(stockName);
        }
    }
}
