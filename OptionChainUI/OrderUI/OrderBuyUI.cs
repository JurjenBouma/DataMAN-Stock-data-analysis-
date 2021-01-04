using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataMAN.Options;
using FinancialData;
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    public partial class OrderBuyUI : UserControl
    {
        public delegate void OrderPlacedHandler(OptionTrade trade);
        public OrderPlacedHandler OrderPlaced;

        private OptionTrade _trade;
        private bool _filled;

        public OrderBuyUI()
        {
            InitializeComponent();
        }

        public async void Fill(OptionTrade trade, DateTime dataDate)
        {
            Clear();
            if (trade.Spread.Options[0] != null || trade.Spread.Options[0].Strike != 0)
            {
                _trade = trade;
                if (trade.Spread.Options[0].Strike > 0 && trade.Spread.Options[1].Strike == 0)
                {
                    if ((trade.Spread.Options[0].OptionType == OptionType.Call && trade.Spread.Options[0].PositionType == PositionType.Short))
                        return;

                    Option[] newSpreadOption = new Option[1];
                    newSpreadOption[0] = trade.Spread.Options[0];
                    _trade.Spread = new Spread(newSpreadOption);
                }
                double cost = await _trade.Spread.Cost(dataDate);
                labelCostValue.Text = cost.ToString();
                _filled = true;
                if (cost > 0)
                    labelCostValue.ForeColor = Color.Green;
                else if (cost < 0)
                    labelCostValue.ForeColor = Color.Red;
            }
        }

        public void Clear()
        {
            labelCostValue.ForeColor = Color.Black;
            labelCostValue.Text = "0.00";
            _filled = false;
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if(_filled)
                OrderPlaced?.Invoke(_trade);
        }
    }
}
