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

namespace DataMAN
{
    public partial class WatchListUI : UserControl
    {
        public delegate void LoadStockHandler(Stock stock);
        public LoadStockHandler LoadStockEvent;
        public bool Linked { get { return _linked; } }
        public bool ShowRecent { get { return panelRecentList.Visible; }
            set
            {
                if (value)
                {
                    panelRecentList.Visible = true;
                    panelWatchList.Location = new Point(0, 322);
                }
                else
                {
                    panelRecentList.Visible = false;
                    panelWatchList.Location = new Point(0, 0);
                }
            }
        }

        private string _activeWatchList = "";
        private Chart _chart;
        private bool _linked = false;

        public WatchListUI()
        {
            InitializeComponent();
        }

        public void Link(Chart chart)
        {
            _chart = chart;
            _chart.StockChanged += new Chart.StockChangedHandler(ActiveStockChanged);
            WatchListManager.ListChanged += new WatchListManager.ListCangedHandler(ListChanged);
            FillComboBoxWatchLists();
            FillListBoxRecent();
            _linked = true;
        }

        private void comboBoxWatchLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            _activeWatchList = comboBoxWatchLists.SelectedItem.ToString();
            FillListBoxWatchList();
        }

        private void listBoxRecent_Click(object sender, EventArgs e)
        {
            if (listBoxRecent.SelectedItem != null && LoadStockEvent != null)
                LoadStockEvent(new Stock(listBoxRecent.SelectedItem.ToString()));
            listBoxRecent.SelectedItem = null;
        }

        private void listBoxWatchList_Click(object sender, EventArgs e)
        {
            if (listBoxWatchList.SelectedItem != null && comboBoxWatchLists.SelectedItem != null && LoadStockEvent != null)
                LoadStockEvent( new Stock(listBoxWatchList.SelectedItem.ToString()));
            listBoxWatchList.SelectedItem = null;
        }

        private void listBoxWatchList_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxWatchList.IndexFromPoint(e.X, e.Y);
                listBoxWatchList.SelectedIndex = index;
                contextMenuStripRemoveStock.Show(listBoxWatchList, e.X, e.Y);
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxWatchList.SelectedItem != null)
            {
                Stock stock = new Stock(listBoxWatchList.SelectedItem.ToString());
                WatchListManager.RemoveFromList(_activeWatchList, stock);
                FillListBoxWatchList();
                listBoxWatchList.SelectedItem = null;
            }
        }

        private void addToolStripMenuItemAddStock_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxStockName.Text.Length > 0 && _activeWatchList.Length > 0)
            {
                Stock stock = new Stock(toolStripTextBoxStockName.Text);
                WatchListManager.AddToList(_activeWatchList, stock);
                FillListBoxWatchList();
                listBoxWatchList.SelectedItem = null;
            }
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxListName.Text.Length > 0)
            {
                WatchListManager.AddNewList(toolStripTextBoxListName.Text);
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_activeWatchList != null)
            {
                if (MessageBox.Show("Are you sure you want to remove " + _activeWatchList, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    WatchListManager.RemoveList(_activeWatchList);
            }
        }

        private void labelWatchLists_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripWatchList.Show(labelWatchLists, e.X, e.Y);
            }
        }

        private void ActiveStockChanged()
        {
            if (_chart.StockData.MetaData.Information.Length > 0)
                AddToRecentList(_chart.Stock);
        }

        private void FillListBoxWatchList()
        {
            string selected = "";
            if (_activeWatchList != null)
                selected = _activeWatchList;
            StockList list = WatchListManager.GetList(selected);
            listBoxWatchList.Items.Clear();
            if (list != null)
                listBoxWatchList.Items.AddRange(list.Stocks);
        }

        private void FillListBoxRecent()
        {
            StockList list = WatchListManager.RecentList;
            listBoxRecent.Items.Clear();
            if (list != null)
                listBoxRecent.Items.AddRange(list.Stocks);
        }

        private void FillComboBoxWatchLists()
        {
            comboBoxWatchLists.Items.Clear();
            foreach (string list in WatchListManager.WatchLists)
            {
                comboBoxWatchLists.Items.Add(list);
            }
        }

        private void AddToRecentList(Stock stock)
        {
            WatchListManager.AddToRecentList(stock);
            FillListBoxRecent();
        }

        private void ListChanged()
        {
            FillComboBoxWatchLists();
            FillListBoxWatchList();
        }
    }
}
