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
using DataMAN.Options;

namespace DataMAN
{
    public partial class ChartPanel : UserControl
    {
        public delegate void LoadStockHandler(Stock stock, Api.Interval interval);
        public LoadStockHandler LoadStockEvent;
        public Chart _trainerChart;

        public ChartPanel()
        {
            InitializeComponent();
        }

        public void Initialize(StockData data)
        {
            chartControl1.ViewIntervalSelector = false;
            chartControl1.ShowCandleDate = false;
            _trainerChart = new Chart();
            chartControl1.Link(_trainerChart);
            chartControl1.LoadStockEvent += new ChartControl.LoadStockHandler(LoadStockChart);
            LoadStockData(data);
        }

        public void LoadStockData(StockData data)
        {
            _trainerChart.LoadStockData(data);
        }

        public void Draw()
        {
            chartControl1.Draw();
        }

        public void Render()
        {
            chartControl1.RenderChart();
        }

        private void LoadStockChart(Stock stock, Api.Interval interval)
        {
            LoadStockEvent?.Invoke(stock, interval);
        }
    }
}
