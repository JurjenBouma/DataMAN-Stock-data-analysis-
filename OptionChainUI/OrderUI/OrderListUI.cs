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
    public partial class OrderListUI : UserControl
    {
        public delegate void QuantityChangedHandler(int quantity);
        public QuantityChangedHandler QuanityChanged;

        public OrderListUI()
        {
            InitializeComponent();
            orderLineUI1.QuantityChanged += new OrderLineUI.QuantityChangedHandler(QuantityChanged);
            orderLineUI2.QuantityChanged += new OrderLineUI.QuantityChangedHandler(QuantityChanged);
        }

        private void QuantityChanged(int quantity)
        {
            QuanityChanged?.Invoke(quantity);
        }

        public void Fill(OptionTrade trade, DateTime dataDate)
        {
            Clear();
            if (trade.Spread.Options[0] != null)
            {
                if (trade.Spread.Options[0].Strike > 0)
                {
                    OptionChain chain = OptionDataBase.Get(trade.Spread.Stock, dataDate);
                    OptionChainDataPoint option1 = chain.FindOption(trade.Spread.Options[0].OptionType, trade.Spread.Options[0].ExpirationDate, trade.Spread.Options[0].Strike);
                    if (trade.Spread.Options[0].PositionType == PositionType.Long)
                        orderLineUI1.Fill(option1, trade.Amount);
                    else if (trade.Spread.Options[0].PositionType == PositionType.Short)
                        orderLineUI1.Fill(option1, trade.Amount * -1);
                }
            }
            if (trade.Spread.Options[1] != null)
            {
                if (trade.Spread.Options[1].Strike > 0)
                {
                    OptionChain chain = OptionDataBase.Get(trade.Spread.Stock, dataDate);
                    OptionChainDataPoint option1 = chain.FindOption(trade.Spread.Options[1].OptionType, trade.Spread.Options[1].ExpirationDate, trade.Spread.Options[1].Strike);
                    if (trade.Spread.Options[1].PositionType == PositionType.Long)
                        orderLineUI2.Fill(option1, trade.Amount);
                    else if (trade.Spread.Options[1].PositionType == PositionType.Short)
                        orderLineUI2.Fill(option1, trade.Amount * -1);
                }
            }
        }

        public void Clear()
        {
            orderLineUI1.Clear();
            orderLineUI2.Clear();
        }
    }
}
