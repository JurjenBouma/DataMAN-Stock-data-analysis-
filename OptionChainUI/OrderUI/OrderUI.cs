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
    public partial class OrderUI : UserControl
    {
        public EventHandler ClearClicked;
        public EventHandler SwapClicked;
        public EventHandler QuantityMoreClicked;
        public EventHandler QuantityLessClicked;
        public EventHandler StrikesUpClicked;
        public EventHandler StrikesDownClicked;
        public delegate void OrderPlacedHandler(OptionTrade trade);
        public OrderPlacedHandler OrderPlacedClicked;
        public delegate void QuanitityChangedHandler(int quanitity);
        public QuanitityChangedHandler QuanitityChanged;

        public OrderUI()
        {
            InitializeComponent();
            orderListUI1.QuanityChanged += new OrderListUI.QuantityChangedHandler(FireQuanitityChanged);
            orderBuyUI1.OrderPlaced += new OrderBuyUI.OrderPlacedHandler(FireOrderPlaced);
        }

        public void ViewOrder(OptionTrade trade, DateTime dataDate)
        {
            orderListUI1.Fill(trade, dataDate);
            orderBuyUI1.Fill(trade, dataDate);
            FillLabelsGainLoss(trade, dataDate);
        }

        private async void FillLabelsGainLoss(OptionTrade trade, DateTime dataDate)
        {
            double maxGain = await trade.Spread.MaxProfit(dataDate) * trade.Amount;
            labelMaxGainValue.Text = maxGain.ToString();

            double maxLoss = await trade.Spread.MaxLoss(dataDate) * -trade.Amount;
            labelMaxLossValue.Text = maxLoss.ToString();
        }


        public void Clear()
        {
            orderListUI1.Clear();
            orderBuyUI1.Clear();
            labelMaxLossValue.Text = "";
            labelMaxGainValue.Text = "";
        }

        private void FireOrderPlaced(OptionTrade trade)
        {
            OrderPlacedClicked?.Invoke(trade);
        }

        private void FireQuanitityChanged(int quanitity)
        {
            QuanitityChanged?.Invoke(quanitity);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearClicked?.Invoke(this, e);
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            SwapClicked?.Invoke(this, e);
        }

        private void buttonQuantityMore_Click(object sender, EventArgs e)
        {
            QuantityMoreClicked?.Invoke(this, e);
        }

        private void buttonQuantityLess_Click(object sender, EventArgs e)
        {
            QuantityLessClicked?.Invoke(this, e);
        }

        private void buttonStrikesDown_Click(object sender, EventArgs e)
        {
            StrikesDownClicked?.Invoke(this, e);
        }

        private void buttonStrikesUp_Click(object sender, EventArgs e)
        {
            StrikesUpClicked?.Invoke(this, e);
        }
    }
}
