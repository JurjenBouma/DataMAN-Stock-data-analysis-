using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData.HistoricalOptionData;
using DataMAN.Options;

namespace DataMAN
{
    public partial class PositionLine : UserControl
    {
        public delegate void SellPositionHandler(OptionTrade trade);
        public SellPositionHandler SellPositionEvent;

        public delegate void SymbolClickedHandler(Stock stock);
        public SymbolClickedHandler SymbolClicked;

        private OptionPosition _position;
        private DateTime _dataDate;

        public PositionLine(OptionPosition position , DateTime date)
        {
            InitializeComponent();
            _position = position;
            _dataDate = date;
            FillLabels();
        }

        public void ChangeDate(DateTime date)
        {
            _dataDate = date;
            FillLabels();
        }

        private async void FillLabels()
        {
            labelSymbol.Text = _position.Spread.Stock.StockSymbol + "(" + _position.Spread.DaysUntilExpiration(_dataDate).ToString() + ")";
            labelPosType.Text = _position.Spread.Type.ToString();

            double stockPrice = await _position.Spread.Stock.Price(_dataDate);
            labelStockPrice.Text = stockPrice.ToString();

            double price = await _position.Spread.Price(_dataDate);
            labelPrice.Text = price.ToString();

            labelQuanitity.Text = _position.Amount.ToString();

            double value = await _position.Spread.PositionValue(_dataDate, _position.Amount);
            labelTotalValue.Text = value.ToString();

            double cost = await _position.Spread.PositionValue(_position.EntryDate, _position.Amount);
            labelCost.Text = cost.ToString();

            if (_position.Spread.Options.Length > 0)
            {
                labelStrikes.Text = _position.Spread.Options[0].Strike.ToString();
                labelStrikes.Visible = true;
                if (_position.Spread.Options.Length > 1)
                {
                    labelStrikes.Text += ", " + _position.Spread.Options[1].Strike.ToString();
                }
            }
            else
                labelStrikes.Visible = false;

            double profit = value - cost;
            labelProfit.Text = profit.ToString();

            double breakEven = await _position.Spread.BreakEven(_position.EntryDate);
            labelBreakEven.Text = breakEven.ToString();

            if (value > cost)
            {
                labelTotalValue.BackColor = Color.Green;
                labelPrice.BackColor = Color.Green;
                labelProfit.BackColor = Color.Green;
            }
            else if (value < cost)
            {
                labelTotalValue.BackColor = Color.Red;
                labelPrice.BackColor = Color.Red;
                labelProfit.BackColor = Color.Red;
            }
            else
            {
                labelTotalValue.BackColor = Color.FromArgb(64, 64, 64);
                labelPrice.BackColor = Color.FromArgb(64, 64, 64);
                labelProfit.BackColor = Color.FromArgb(64, 64, 64);
            }

            double entryStockPrice = await _position.Spread.Stock.Price(_position.EntryDate);
            if (stockPrice > entryStockPrice)
            {
                labelStockPrice.BackColor = Color.Green;
            }
            else if (stockPrice < entryStockPrice)
            {
                labelStockPrice.BackColor = Color.Red;
            }
            else
            {
                labelStockPrice.BackColor = Color.FromArgb(64, 64, 64);
            }
        }

        private void PositionLine_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStripSell.Show((Control)sender, e.X, e.Y);
            }
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionTrade trade = new OptionTrade()
            {
                Amount = 0,
                TradeDate = _dataDate,
                Spread = _position.Spread
            };

            SellPositionEvent?.Invoke(trade);
        }

        private void labelSymbol_Click(object sender, EventArgs e)
        {
            SymbolClicked?.Invoke(_position.Spread.Stock);
        }
    }
}
