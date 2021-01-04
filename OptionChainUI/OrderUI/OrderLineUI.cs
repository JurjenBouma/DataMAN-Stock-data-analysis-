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
    public partial class OrderLineUI : UserControl
    {
        public delegate void QuantityChangedHandler(int quantity);
        public QuantityChangedHandler QuantityChanged;

        private bool _isFilling = false;

        public OrderLineUI()
        {
            InitializeComponent();
            Clear();
        }

        public void Clear()
        {
            FillLabels(null, 0);
        }

        public void Fill(OptionChainDataPoint option, int amount)
        {
            FillLabels(option, amount);
        }

        private void FillLabels(OptionChainDataPoint option, int amount)
        {
            _isFilling = true;
            if (option != null)
            {
                numericUpDownQuantity.Visible = true;
                numericUpDownQuantity.Value = amount;
                labelDate.Text = option.Experation.ToString("MMM dd");
                labelDaysOut.Text = (option.Experation - option.DataDate).TotalDays.ToString();
                labelStrike.Text = option.Strike.ToString();
                labelType.Text = option.Type.ToString().Substring(0, 1);

                if (amount < 0)
                {
                    labelOrderType.Text = "STO";
                    labelOrderType.ForeColor = Color.Red;
                }
                else
                {
                    labelOrderType.Text = "BTO";
                    labelOrderType.ForeColor = Color.Green;
                }
            }
            else
            {
                numericUpDownQuantity.Visible = false;
                labelDate.Text = "";
                labelDaysOut.Text = "";
                labelStrike.Text = "";
                labelType.Text = "";
                labelOrderType.Text = "";
            }
            _isFilling = false;
        }

        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (!_isFilling)
            {
                int value = (int)numericUpDownQuantity.Value;
                if (value == 0)
                    value = 1;
                QuantityChanged?.Invoke(Math.Abs(value));
            }
        }
    }
}
