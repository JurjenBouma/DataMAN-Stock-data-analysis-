using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMAN
{
    public partial class ChainPanel : UserControl
    {
        public delegate void OrderPlacedClickedHandler(OptionTrade trade);
        public OrderPlacedClickedHandler OrderPlaced;

        private OptionChainUI _chainUI;
        private DateTime _currentDate;

        public ChainPanel()
        {
            InitializeComponent();
        }

        public void Initialize(double cash, DateTime simDate, Stock stock)
        {
            AddChainUI(stock, simDate);
            InitOrderUI();
            _chainUI.Location = new Point(panelChain.Width / 2 - _chainUI.Width / 2, 0);
            _currentDate = simDate;
        }

        public void ViewTrade(OptionTrade trade, DateTime date)
        {
            _currentDate = date;
            _chainUI.SetTrade(trade);
            orderUI1.ViewOrder(trade, _currentDate);
        }

        public void Clear()
        {
            orderUI1.Clear();
            _chainUI.ClearSelection();
        }

        private void AddChainUI(Stock stock, DateTime simDate)
        {
            _chainUI = new OptionChainUI(stock, simDate , false);
            _chainUI.TradeChanged += new OptionChainUI.TradeChangedHandler(ChainUITradeChanged);
            panelChain.Controls.Add(_chainUI);
        }

        private void InitOrderUI()
        {
            orderUI1.ClearClicked += new EventHandler(ClearedClicked);
            orderUI1.SwapClicked += new EventHandler(SwapClicked);
            orderUI1.QuantityMoreClicked += new EventHandler(QuantityMoreClicked);
            orderUI1.QuantityLessClicked += new EventHandler(QuantityLessClicked);
            orderUI1.StrikesUpClicked += new EventHandler(StrikesUpClicked);
            orderUI1.StrikesDownClicked += new EventHandler(StrikesDownClicked);
            orderUI1.QuanitityChanged += new OrderUI.QuanitityChangedHandler(QuantityChanged);
            orderUI1.OrderPlacedClicked += new OrderUI.OrderPlacedHandler(OrderPlacedClicked);
        }

        private void ChainUITradeChanged(OptionTrade trade)
        {
            orderUI1.ViewOrder(trade, _currentDate);
        }

        public void RelocateChainUI()
        {
            _chainUI.Location = new Point(panelChain.Width / 2 - _chainUI.Width / 2, 0);
            
        }

        public void LoadStock(Stock stock , DateTime date)
        {
            if (stock.StockSymbol.Length > 0)
            {
                _currentDate = date;
                _chainUI.ChangeStock(stock, date);
            }
        }

        private void ClearedClicked(object sender, EventArgs e)
        {
            Clear();
        }

        private void SwapClicked(object sender, EventArgs e)
        {
            _chainUI.SwapOptions();
        }

        private void QuantityMoreClicked(object sender, EventArgs e)
        {
            OptionTrade currentTrade = _chainUI.CurrentTrade;
            _chainUI.ChangeTradeQuantity(currentTrade.Amount + 1);
        }

        private void QuantityLessClicked(object sender, EventArgs e)
        {
            OptionTrade currentTrade = _chainUI.CurrentTrade;
            _chainUI.ChangeTradeQuantity(currentTrade.Amount - 1);
        }

        private void QuantityChanged(int quantity)
        {
            _chainUI.ChangeTradeQuantity(quantity);
        }

        private void StrikesUpClicked(object sender, EventArgs e)
        {
            _chainUI.MoveStrikesUp();
        }

        private void StrikesDownClicked(object sender, EventArgs e)
        {
            _chainUI.MoveStrikesDown();
        }

        private void OrderPlacedClicked(OptionTrade trade)
        {
            Clear();
            OrderPlaced?.Invoke(trade);
        }
    }
}
