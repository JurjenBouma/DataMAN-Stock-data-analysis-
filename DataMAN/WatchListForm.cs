using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMAN
{
    partial class WatchListForm : Form
    {
        string _activeStockList;

        public WatchListForm()
        {
            InitializeComponent();
            FillListBoxWatchLists();
        }

        private void listBoxWatchLists_Click(object sender, EventArgs e)
        {
            if (listBoxWatchLists.SelectedItem != null)
            {
                string list = listBoxWatchLists.SelectedItem.ToString();
                _activeStockList = list;
                FillListBoxStocks();
            }
            listBoxWatchLists.SelectedItem = null;
        }

        private void listBoxWatchLists_RightClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                int index = listBoxWatchLists.IndexFromPoint(e.X, e.Y);
                listBoxWatchLists.SelectedIndex = index;
                contextMenuStripList.Show(listBoxWatchLists, e.X, e.Y);
            }
        }

        private void listBoxStocks_RightClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int index = listBoxStocks.IndexFromPoint(e.X, e.Y);
                listBoxStocks.SelectedIndex = index;
                contextMenuStripStock.Show(listBoxStocks, e.X, e.Y);
            }
        }

        private void buttonAddNewList_Click(object sender, EventArgs e)
        {
            _activeStockList = textBoxWatchListName.Text;
            WatchListManager.AddNewList(_activeStockList);
            FillListBoxWatchLists();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            WatchListManager.AddToList(_activeStockList,new Stock(textBoxStockName.Text));
            FillListBoxStocks();
        }

        private void removeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxWatchLists.SelectedItem != null)
            {
                string list = listBoxWatchLists.SelectedItem.ToString();
                WatchListManager.RemoveList(list);
                FillListBoxWatchLists();
                listBoxWatchLists.SelectedItem = null;
            }
        }

        private void removeStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxStocks.SelectedItem != null)
            {
                WatchListManager.RemoveFromList(_activeStockList, new Stock(listBoxStocks.SelectedItem.ToString()));
                FillListBoxStocks();
                listBoxStocks.SelectedItem = null;
            }
        }

        private void FillListBoxWatchLists()
        {
            listBoxWatchLists.Items.Clear();
            foreach (string list in WatchListManager.WatchLists)
            {
                listBoxWatchLists.Items.Add(list);
            }
        }

        private void FillListBoxStocks()
        {
            listBoxStocks.Items.Clear();
            foreach (string stock in WatchListManager.GetList(_activeStockList).Stocks)
            {
                listBoxStocks.Items.Add(stock);
            }
        }
    }
}
