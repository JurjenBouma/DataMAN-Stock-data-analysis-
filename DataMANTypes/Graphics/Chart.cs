using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using System.Windows.Forms;
using FinancialData;

namespace DataMAN
{
    public class Chart
    {
        public StockData StockData { get { return activeStockData; } }
        public Stock Stock { get { return activeStock; } }
        public int CandleCount { get { return candleCount; } }
        public delegate void StockChangedHandler();
        public event StockChangedHandler StockChanged;
        public Api.Interval Interval = Api.Interval.Daily;
        public int ChartRange { get { return chartRange; } }
        public int ChartIndex { get { return chartIndex; } }
        public int DefaultRange = 100;


        ChartGraphic chart;
        StockData activeStockData;
        Stock activeStock;
        int candleCount;
        int chartRange = 100;
        int chartIndex;
        PictureBox renderPictureBox;
        public List<GraphData> Graphs;

        public Chart()
        {
        }

        public void Link(PictureBox renderBox)
        {
            renderPictureBox = renderBox;
            chart = new ChartGraphic();
            activeStockData = new StockData();
            Graphs = new List<GraphData>();
        }

        public void Scroll(int index , int range)
        {
            chartRange = range;
            if (candleCount < chartRange)
                chartRange = candleCount;

            chartIndex = index;
        }

        public void DrawChart()
        {
            if (activeStock != null)
                chart.DrawChart(renderPictureBox);
        }

        public void RenderChart()
        {
            if(activeStock != null)
                chart.RenderChart(renderPictureBox, activeStockData , chartIndex, chartRange, Graphs.ToArray());
        }

        public void DrawCursor(int mouseX , int mouseY)
        {
            if (activeStock != null)
            {
                chart.DrawCursor(mouseX, mouseY);
                DrawChart();
            }
        }

        public StockDataPoint PickStockData(int mouseX)
        {
            if (activeStock != null)
                return chart.PickStockData(StockData, mouseX, chartIndex, chartRange);
            else
                return new StockDataPoint();
        }

        public async Task<bool> LoadStock(Stock stock)
        {
            if (stock != null)
            {
                StockData tempData = await StockDataBase.Get(stock, Interval);

                int tempDataCount = tempData.TimeSeries.DataPoints.Count;

                if (tempDataCount > 0)
                {
                    Stock prevstock = activeStock;
                    activeStock = stock;
                    activeStockData = tempData;

                    candleCount = tempDataCount;
                    DefaultRange = 100;
                    chartRange = DefaultRange;

                    if (candleCount < chartRange)
                        chartRange = candleCount;

                    DefaultRange = chartRange;

                    if (StockChanged != null)
                        StockChanged();

                    return true;
                }
            }
            return false;
        }

        public void LoadStockData(StockData stockData)
        {
            if (stockData != null)
            {
                StockData tempData = stockData;

                int tempDataCount = tempData.TimeSeries.DataPoints.Count;

                if (tempDataCount > 0)
                {
                    activeStock = new Stock(stockData.MetaData.Symbol);
                    activeStockData = tempData;

                    candleCount = tempDataCount;
                    DefaultRange = 100;
                    chartRange = DefaultRange;

                    if (candleCount < chartRange)
                        chartRange = candleCount;

                    DefaultRange = chartRange;

                    if (StockChanged != null)
                        StockChanged();
                }
            }
        }
    }

}
