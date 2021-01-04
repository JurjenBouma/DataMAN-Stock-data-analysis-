using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using FinancialData.AlphaVantage;
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    public partial class PluginControl : UserControl
    {
        public PluginControl()
        {
            InitializeComponent();
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            Stock stock = GlobalObjects.Chart.Stock;
            textBoxStock.Text = stock.StockSymbol;
            StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);
            int dataCount = data.TimeSeries.DataPoints.Count;

            double simCash = 10000;
            DateTime simStartDate = new DateTime(2016, 1, 1);
            DateTime simEndDate = new DateTime(2017, 5, 1);
            double alpha = GetStockAlphaBalance(data, simCash, simStartDate, simEndDate);
            double tradeResult = 0;
            IOptionTradeAlgorithm tradeAlgo = new BuyAndManageLCV();

            OptionTradeList tradeList = await tradeAlgo.Find(stock, simStartDate, simEndDate);

            OptionTradeSimulation sim = new OptionTradeSimulation("OptionSim" , simCash, simStartDate, simEndDate,1.1,0.04);

            sim.Run(tradeList);
            GlobalObjects.Chart.Graphs.Clear();
            GlobalObjects.Chart.Graphs.Add(sim.BalanceChart);

            tradeResult = sim.BalanceChart.DataPoints[sim.BalanceChart.DataPoints.Count -1].GraphData;


            labelResultRightPercent.Text = tradeResult.ToString();
            labelResultAlpha.Text = alpha.ToString();
        }

        private double GetStockAlphaBalance(StockData data, double cash , DateTime startDate, DateTime endDate)
        {
            int dataCount = data.TimeSeries.DataPoints.Count;
            int startIndex = data.FindDateIndex(startDate);
            int stopIndex = data.FindDateIndex(endDate);

            if (stopIndex == 0)
                stopIndex = dataCount - 1;

            double alpha = Indicators.GetStockAlpha(data, startIndex, stopIndex - startIndex + 1);
            return cash * alpha;
        }
    }
}
