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
    public partial class PositionListUI : UserControl
    {
        public delegate void SellPositionHandler(OptionTrade trade);
        public SellPositionHandler SellPositionEvent;

        public delegate void SymbolClickedHandler(Stock stock);
        public SymbolClickedHandler SymbolClicked;

        public PositionListUI()
        {
            InitializeComponent();
        }

        public void ChangeDate(DateTime date)
        {
            foreach (Control c in panelPositions.Controls)
            {
                if (c is PositionLine)
                {
                    ((PositionLine)c).ChangeDate(date);
                }
            }
        }

        public void Fill(List<OptionPosition> positions , DateTime date)
        {
            panelPositions.Controls.Clear();
            int skipped = 0;
            for(int i =0; i< positions.Count;i++)
            {
                if (positions[i].Amount > 0)
                {
                    PositionLine line = new PositionLine(positions[i], date);
                    line.Location = new Point(0, 32 * (i-skipped));
                    line.SellPositionEvent += new PositionLine.SellPositionHandler(FireSellEvent);
                    line.SymbolClicked += new PositionLine.SymbolClickedHandler(FireSymbolClicked);
                    panelPositions.Controls.Add(line);
                }
                else
                    skipped++;
            }
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
