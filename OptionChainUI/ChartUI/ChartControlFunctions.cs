using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData.AlphaVantage;
using System.IO;
using System.Drawing.Drawing2D;
using FinancialData;

namespace DataMAN
{
    public partial class ChartControl : UserControl
    { 
        float zoomPercent = 1f;

        public void Draw()
        {
            if (Linked)
                _chart.DrawChart();
        }

        public void RenderChart()
        {
            if (Linked)
                _chart.RenderChart();
        }

        public void ActiveStockChanged()
        {
            //zoomPercent = 1f;
            ScrollChart();
            ResetChartScrollBar();
            //hScrollBarChart.Value = hScrollBarChart.Maximum;
            FillControlValues();
            RenderChart();
            Draw();
        }

        private void FillComboBoxTimeChart()
        {
            if (Linked)
            {
                comboBoxTimeChart.Items.Clear();

                foreach (Api.Interval interval in (Api.Interval[])Enum.GetValues(typeof(Api.Interval)))
                {
                    comboBoxTimeChart.Items.Add(interval);
                }
                comboBoxTimeChart.SelectedItem = _chart.Interval;
            }
        }

        private void FillControlValues()
        {
            if (Linked)
            {
                int dataCount = _chart.StockData.TimeSeries.DataPoints.Count;
                textBoxStock.Text = _chart.Stock.StockSymbol;
                textBoxValue.Text = _chart.StockData.TimeSeries.DataPoints[dataCount - 1].Close.ToString();
                textBoxVolatility2W.Text = "";
                textBoxVolatility4W.Text = "";
                textBoxVolatility2M.Text = "";

                if (_chart.Interval == Api.Interval.Daily)
                {
                    if (dataCount > 10)
                        textBoxVolatility2W.Text = (Indicators.GetAnualVolatility(_chart.StockData, dataCount - 1, 10, PricePoint.Close) * 100).ToString("0.0") + "%";
                    if (dataCount > 20)
                        textBoxVolatility4W.Text = (Indicators.GetAnualVolatility(_chart.StockData, dataCount - 1, 20, PricePoint.Close) * 100).ToString("0.0") + "%";
                    if (dataCount > 40)
                        textBoxVolatility2M.Text = (Indicators.GetAnualVolatility(_chart.StockData, dataCount - 1, 40, PricePoint.Close) * 100).ToString("0.0") + "%";
                }
            }
        }

        private void UpdateLableStockData(int mouseX, int mouseY)
        {
            if (Linked)
            {
                if (_chart.StockData != null)
                {
                    StockDataPoint mouseDataPoint = _chart.PickStockData(mouseX);
                    if (ShowCandleDate)
                        labelStockData.Text = "Date : " + mouseDataPoint.DateTime.ToString("dddd dd MMMM yyyy");
                    else
                        labelStockData.Text = "Date : " + mouseDataPoint.DateTime.ToString("dddd dd MMMM");
                    labelStockData.Text += "\nOpen : " + mouseDataPoint.Open.ToString() + "\nClose : " + mouseDataPoint.Close.ToString() + "\nVolume : " + mouseDataPoint.Volume.ToString();
                    labelStockData.Location = new Point(pictureBoxRender.Width - labelStockData.Width - 10, labelStockData.Location.Y);

                    if (_chart.Graphs.Count > 0)
                    {
                        foreach (GraphData graph in _chart.Graphs)
                        {
                            int graphIndex = graph.FindDateIndex(mouseDataPoint.DateTime);
                            GraphDataPoint graphDataPoint = graph.DataPoints[graphIndex];
                            labelGraphData.Text = "Date : " + graphDataPoint.DateTime.ToShortDateString() + "\nValue : " + graphDataPoint.GraphData.ToString();
                            labelGraphData.Location = new Point(pictureBoxRender.Width - labelGraphData.Width - 10, labelGraphData.Location.Y);
                        }
                    }
                }
            }        
        }

        private void UpdatePriceCursor(int mouseX, int mouseY)
        {
            if (Linked)
            {
                _chart.DrawCursor(mouseX, mouseY);
            }
        }

        private void ScrollChart()
        {
            if (Linked)
            {
                int range = (int)(_chart.DefaultRange * zoomPercent);
                _chart.Scroll(hScrollBarChart.Value, range);
            }
        }

        private void ResetChartScrollBar()
        {
            if (Linked)
            {
                int prevValue = hScrollBarChart.Value;
                int prevMax = hScrollBarChart.Maximum;

                hScrollBarChart.Maximum = _chart.CandleCount - _chart.ChartRange;
                int newValue = prevValue + (hScrollBarChart.Maximum - prevMax);
                if (newValue > hScrollBarChart.Maximum)
                    newValue = hScrollBarChart.Maximum;
                if (newValue < 0)
                    newValue = 0;
                hScrollBarChart.Value = newValue;
                ScrollChart();
            }
        }

        private void FillContextMenuWatchLists()
        {
            if (Linked)
            {
                addToWatchlistToolStripMenuItem.DropDownItems.Clear();
                foreach (string list in WatchListManager.WatchLists)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem();
                    item.Text = list;
                    item.Click += new EventHandler(toolStipItemAddToWatchList_Click);
                    addToWatchlistToolStripMenuItem.DropDownItems.Add(item);
                }
            }
        }
    }
}
