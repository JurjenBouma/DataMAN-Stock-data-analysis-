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

namespace DataMAN
{
    public partial class ChartControl : UserControl
    {
        public delegate void LoadStockHandler(Stock stock , Api.Interval interval);
        public LoadStockHandler LoadStockEvent;
        public bool Linked = false;
        public bool ShowCandleDate = true;

        private Chart _chart;
        private Point _prevMousePoint;

        public ChartControl()
        {
            InitializeComponent();
            _prevMousePoint = new Point(0, 0);
        }

        public void Link(Chart chart)
        {
            _chart = chart;
            _chart.Link(pictureBoxRender);
            _chart.StockChanged += new Chart.StockChangedHandler(ActiveStockChanged);
            Linked = true;
            FillComboBoxTimeChart();
        }

        private void chartMouseWheel(object sender, MouseEventArgs e)
        {
            if (Linked)
            {
                if (e.Delta < 0)
                {
                    zoomPercent *= 1.1f;
                    if ((int)(_chart.DefaultRange * zoomPercent) > 400)
                        zoomPercent = 1f / _chart.DefaultRange * 400;
                }
                else
                {
                    zoomPercent *= 0.9f;
                    if ((int)(_chart.DefaultRange * zoomPercent) < 1)
                        zoomPercent = 1f / _chart.DefaultRange + 0.001f;
                }
                ScrollChart();
                ResetChartScrollBar();
                RenderChart();
                Draw();
            }
        }

        public bool ViewIntervalSelector
        {
            get { return comboBoxTimeChart.Visible; }
            set
            {
                labelChartInterval.Visible = value;
                comboBoxTimeChart.Visible = value;
            }
        }

        public bool ViewControls
        {
            get { return panelChartControls.Visible; }
            set
            {
                panelChartControls.Visible = value;
                if (value == false)
                {
                    panelChartGraphicBorder.Dock = DockStyle.Fill;
                }
                else
                {
                    panelChartGraphicBorder.Dock = DockStyle.None;
                }
            }
        }

        private void hScrollBarChart_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollChart();
            RenderChart();
            Draw();
        }

        private void textBoxStock_KeyUp(object sender, KeyEventArgs e)
        {
            if (Linked)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (LoadStockEvent != null)
                        LoadStockEvent(new Stock(textBoxStock.Text), (Api.Interval)comboBoxTimeChart.SelectedItem);
                }
            }
        }

        private void pictureBoxRender_MouseUp(object sender, MouseEventArgs e)
        {
            if (Linked)
            {
                if (e.Button == MouseButtons.Right)
                {
                    FillContextMenuWatchLists();
                    contextMenuStripStock.Show(pictureBoxRender, e.X, e.Y);
                }
            }
        }

        private void toolStipItemAddToWatchList_Click(object sender, EventArgs e)
        {
            if (Linked)
            {
                if (_chart.Stock != null)
                {
                    ToolStripMenuItem item = (ToolStripMenuItem)sender;
                    WatchListManager.AddToList(item.Text, _chart.Stock);
                }
            }
        }

        private void comboBoxTimeChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Linked)
            {
                if (LoadStockEvent != null)
                {
                    LoadStockEvent(new Stock(textBoxStock.Text), (Api.Interval)comboBoxTimeChart.SelectedItem);
                }
            }
        }

        private void pictureBoxRender_MouseMove(object sender, MouseEventArgs e)
        {
            if (Linked)
            {
                if (e.Location != _prevMousePoint)
                {
                    UpdateLableStockData(e.X, e.Y);
                    UpdatePriceCursor(e.X, e.Y);
                }
               
                _prevMousePoint = e.Location;
            }
        }

        private void pictureBoxRender_MouseEnter(object sender, EventArgs e)
        {
            if (Linked)
            {
                if (_chart.StockData.TimeSeries.DataPoints.Count > 0)
                {
                    labelStockData.Visible = true;
                    if (_chart.Graphs.Count > 0)
                        labelGraphData.Visible = true;
                }
            }
        }

        private void pictureBoxRender_MouseLeave(object sender, EventArgs e)
        {
            if (Linked)
            {
                if (_chart.StockData.TimeSeries.DataPoints.Count > 0)
                {
                    labelStockData.Visible = false;
                    labelGraphData.Visible = false;
                    UpdatePriceCursor(-1, -1);
                }
            }
        }
    }
}
