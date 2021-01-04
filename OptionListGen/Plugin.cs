using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using FinancialData.AlphaVantage;
using System.IO;
using System.Threading;

namespace DataMAN
{
    public class Plugin : IAnalizer
    {
        private Panel panelControl;
        private Panel panelVariable;

        public string Name { get { return "Build a stocklist based on histoical option avaible"; } }

        public async void Load(Panel controlPanel, Panel variablePanel)
        {
            panelControl = controlPanel;
            panelVariable = variablePanel;
            string dataBasePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\Financial data\\Options\\HistoricalOptionData";
            string listName = "Historical Data";
            /*WatchListManager.AddNewList(listName);
            foreach (string stockFolder in Directory.GetDirectories(dataBasePath))
            {
                DirectoryInfo dInfo = new DirectoryInfo(stockFolder);
                string symbol = dInfo.Name;
                Stock stock = new Stock(symbol);
                WatchListManager.AddToList(listName, stock);
            }*/
            if (MessageBox.Show("ready") == DialogResult.OK)
            {
                StockList list = WatchListManager.GetList("Historical Data");
                foreach (string symbol in list.Stocks)
                {
                    Stock stock = new Stock(symbol);
                    StockData data = await StockDataBase.Get(stock, Api.Interval.Daily, TimeSpan.FromDays(200));

                    DateTime lastRefeshed;
                    try
                    {
                        lastRefeshed = DateTime.Parse(data.MetaData.LastRefreshed);
                    }
                    catch
                    {
                        lastRefeshed = DateTime.MinValue;
                    }

                    if (DateTime.UtcNow - lastRefeshed < TimeSpan.FromMinutes(10))
                    {
                        Thread.Sleep(new TimeSpan(0, 0, 25));
                    }
                }
                MessageBox.Show("Done");
            }
        }

        public void UnLoad()
        {
            panelControl.Controls.Clear();
            panelVariable.Controls.Clear();
        }
    }
}
