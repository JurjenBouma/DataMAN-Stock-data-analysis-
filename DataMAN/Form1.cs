using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using FinancialData.AlphaVantage;
using System.IO;
using System.Drawing.Drawing2D;

namespace DataMAN
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            GlobalObjects.Initialize();
            Api.Initialize(File.ReadAllText("AlphavantageKey.txt"));
            StockDataBase.Initialize(TimeSpan.FromHours(5));
            OptionDataBase.Initialize();
            WatchListManager.Initialize();
            InitializeComponent();
            watchListUI.Link(GlobalObjects.Chart);
            chartControl.Link(GlobalObjects.Chart);

            watchListUI.LoadStockEvent += new WatchListUI.LoadStockHandler(LoadStock);
            chartControl.LoadStockEvent += new ChartControl.LoadStockHandler(LoadStockChart);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            PluginManager.UnloadPlugins();
            WatchListManager.Save();
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            chartControl.RenderChart();
            chartControl.Draw();
        }

        private void loadPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialogPlugin.ShowDialog();
        }

        private void openFileDialogPlugin_FileOk(object sender, CancelEventArgs e)
        {
            if(openFileDialogPlugin.FileName.Length > 0)
            {
                PluginManager.LoadPlugin(openFileDialogPlugin.FileName, panelScriptControls, panelVariables);
            }
        }

        private void LoadStockChart(Stock stock , Api.Interval interval)
        {
            GlobalObjects.Chart.Interval = interval;
            LoadStock(stock);
        }

        private async void LoadStock(Stock stock)
        {
            if (stock.StockSymbol.Length > 0)
            {
                await GlobalObjects.Chart.LoadStock(stock);
            }
        }
    }
}
