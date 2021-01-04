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

namespace DataMAN.StockInfoUI
{
    public partial class StockInfoUI : UserControl
    {
        public StockInfoUI()
        {
            InitializeComponent();
        }

        public async void SetStock(Stock stock , DateTime date)
        {
            labelSymbol.Text = stock.StockSymbol;
            double stockPrice = await stock.Price(date);
            labelStockPrice.Text = stockPrice.ToString();
        }
    }
}
