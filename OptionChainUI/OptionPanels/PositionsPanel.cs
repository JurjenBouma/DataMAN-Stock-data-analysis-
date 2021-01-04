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
    public partial class PositionsPanel : UserControl
    {
        public delegate void SellPositionHandler(OptionTrade trade);
        public SellPositionHandler SellPositionEvent;

        public delegate void SymbolClickedHandler(Stock stock);
        public SymbolClickedHandler SymbolClicked;

        public PositionsPanel()
        {
            InitializeComponent();
        }

        public void Initialize(List<OptionPosition> positions, DateTime date)
        {
            Fill(positions, date);
            positionListUI1.SellPositionEvent += new PositionListUI.SellPositionHandler(FireSellEvent);
            positionListUI1.SymbolClicked += new PositionListUI.SymbolClickedHandler(FireSymbolClicked);
        }

        public void Fill(List<OptionPosition> positions, DateTime date)
        {
            positionListUI1.Fill(positions, date);
        }

        private void FireSellEvent(OptionTrade trade)
        {
            SellPositionEvent?.Invoke(trade);
        }

        private void FireSymbolClicked(Stock stock)
        {
            SymbolClicked?.Invoke(stock);
        }

    }
}
