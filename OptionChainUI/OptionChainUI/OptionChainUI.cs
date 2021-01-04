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
using FinancialData;
using FinancialData.AlphaVantage;
using DataMAN.Options;

namespace DataMAN
{
    public partial class OptionChainUI : UserControl
    {
        public delegate void TradeChangedHandler(OptionTrade trade);
        public TradeChangedHandler TradeChanged;
        public OptionTrade CurrentTrade { get { return _previewTrade; } }

        private OptionChain _chain;
        private OptionTrade _previewTrade;
        private int _dragIndex = -1;
        private bool _mouseDown = false;
        private bool _showDates;

        public OptionChainUI(Stock stock, DateTime date , bool showDates)
        {
            _showDates = showDates;
            Init(stock, date);
        }

        public OptionChainUI(Stock stock, DateTime date)
        {
            Init(stock, date);
        }

        private void Init(Stock stock , DateTime date)
        {
            InitializeComponent();
            _chain = OptionDataBase.Get(stock, date);
            FillChainExpandables();
            FillSymbolLabel();
            ClearPreviewTrade();
        }

        public void SetTrade(OptionTrade trade)
        {
            _previewTrade = trade;
            foreach(OptionChainDateExpandable expandable in panelChain.Controls)
            {
                expandable.ShowTrade(trade);
            }

            TradeChanged?.Invoke(trade);
        }

        public void ChangeTradeQuantity(int quantity)
        {
            if (_previewTrade.Spread.Options[0].Strike > 0)
            {
                OptionTrade newTrade = _previewTrade;
                if (quantity >= 1)
                {
                    newTrade.Amount = quantity;
                    SetTrade(newTrade);
                }
            }
        }

        public void SwapOptions()
        {
            if (_previewTrade.Spread.Options[0].Strike > 0)
            {
                Option option1 = _previewTrade.Spread.Options[0];
                Option option2 = _previewTrade.Spread.Options[1];

                if(option1.PositionType == PositionType.Long)
                    option1 = new Option(option1.Stock, option1.OptionType, PositionType.Short, option1.Strike, option1.ExpirationDate);
                else 
                    option1 = new Option(option1.Stock, option1.OptionType, PositionType.Long, option1.Strike, option1.ExpirationDate);

                if (option2.PositionType == PositionType.Long)
                    option2 = new Option(option2.Stock, option2.OptionType, PositionType.Short, option2.Strike, option2.ExpirationDate);
                else
                    option2 = new Option(option2.Stock, option2.OptionType, PositionType.Long, option2.Strike, option2.ExpirationDate);
                UpdatePreviewTrade(option1, 0);
                UpdatePreviewTrade(option2, 1);
            }
        }

        public void MoveStrikesUp()
        {
            Option option1 = _previewTrade.Spread.Options[0];
            Option option2 = _previewTrade.Spread.Options[1];

            if (option1.Strike > 0)
            {
                double nextStrike = _chain.FindNextStrike(option1.Strike, option1.ExpirationDate);
                option1 = new Option(option1.Stock, option1.OptionType, option1.PositionType, nextStrike, option1.ExpirationDate);
                UpdatePreviewTrade(option1, 0);
            }
            if (option2.Strike > 0)
            {
                double nextStrike = _chain.FindNextStrike(option2.Strike, option2.ExpirationDate);
                option2 = new Option(option2.Stock, option2.OptionType, option2.PositionType, nextStrike, option2.ExpirationDate);
                UpdatePreviewTrade(option2, 1);
            }
        }

        public void MoveStrikesDown()
        {
            Option option1 = _previewTrade.Spread.Options[0];
            Option option2 = _previewTrade.Spread.Options[1];

            if (option2.Strike > 0)
            {
                double lowerStrike = _chain.FindNextLowerStrike(option2.Strike, option2.ExpirationDate);
                option2 = new Option(option2.Stock, option2.OptionType, option2.PositionType, lowerStrike, option2.ExpirationDate);
                UpdatePreviewTrade(option2, 1);
            }
            if (option1.Strike > 0)
            {
                double lowerStrike = _chain.FindNextLowerStrike(option1.Strike, option1.ExpirationDate);
                option1 = new Option(option1.Stock, option1.OptionType, option1.PositionType, lowerStrike, option1.ExpirationDate);
                UpdatePreviewTrade(option1, 0);
            } 
        }

        public void ClearSelection()
        {
            ClearPreviewTrade();
            foreach (OptionChainDateExpandable expandable in panelChain.Controls)
            {
                expandable.ClearSelection();
            }
            TradeChanged?.Invoke(_previewTrade);
        }

        public void ChangeStock(Stock stock, DateTime date)
        {
            _chain = OptionDataBase.Get(stock, date);
            if (_chain != null)
            {
                FillChainExpandables();
                FillSymbolLabel();
                ClearPreviewTrade();
            }
        }

        private void ClearPreviewTrade()
        {
            Option[] options = new Option[2];
            options[0] = new Option(_chain.Stock, OptionType.Call, PositionType.Long, 0, new DateTime());
            options[1] = new Option(_chain.Stock, OptionType.Call, PositionType.Long, 0, new DateTime());
            _previewTrade.Spread = new Spread(options);
            _previewTrade.Amount = 1;
            _previewTrade.TradeDate = _chain.DataDate;
        }

        private void FillSymbolLabel()
        {
            if (_chain != null)
            {
                labelSymbol.Text = _chain.Stock.StockSymbol;
            }
        }

        private void FillChainExpandables()
        {
            if (_chain != null)
            {
                if (_chain.Options.Count > 0)
                {
                    panelChain.Controls.Clear();
                    DateTime[] experations = _chain.Experations();
                    for (int i = 0; i < experations.Length; i++)
                    {
                        OptionChainDateExpandable dateExpandable = new OptionChainDateExpandable(_chain.SubChain(experations[i]) , _showDates);
                        dateExpandable.Location = new Point(0, i * 32);

                        dateExpandable.SizeChanged += new EventHandler(MoveExpandables);
                        dateExpandable.Clicked += new OptionChainDateExpandable.ClickedHandler(Clicked);
                        dateExpandable.DoubleClicked += new OptionChainDateExpandable.ClickedHandler(DoubleClicked);
                        dateExpandable.Entered += new OptionChainDateExpandable.ClickedHandler(Entered);
                        dateExpandable.MouseMoved += new OptionChainDateExpandable.ClickedHandler(MouseMoved);
                        dateExpandable.MouseButtonUp += new OptionChainDateExpandable.ClickedHandler(MouseButtonUp);
                        panelChain.Controls.Add(dateExpandable);
                    }
                }
            }
        }

        private void Clicked(DateTime exp, double strike,OptionType opType, PositionType posType, MouseEventArgs e)
        {
            Option optionClicked = new Option(_chain.Stock, opType, posType, strike, exp);
            int index = FindOptionIndex(exp, strike, opType);

            if (e.Button == MouseButtons.Left)
            {
                if (index >= 0)
                {
                    _mouseDown = true;
                    _dragIndex = index;
                }
            }

            if (e.Button == MouseButtons.Right)
            {
                if (index >= 0)
                        UpdatePreviewTrade(exp, 0, opType, PositionType.Long, index);
            }
        }

        private void DoubleClicked(DateTime exp, double strike, OptionType opType , PositionType posType, MouseEventArgs e)
        {
            Option optionClicked = new Option(_chain.Stock, opType, PositionType.Long, strike, exp);
            int index = FindOptionIndex(exp, strike, opType);

            if (e.Button == MouseButtons.Left)
            {
                if (index == 0)
                {
                    Option option1 = _previewTrade.Spread.Options[0];
                    Option option2 = _previewTrade.Spread.Options[1];

                    if (option1.Strike > 0)
                        SwapOptions();
                    else
                        UpdatePreviewTrade(optionClicked, index);
                }
                if (index == 1)
                {
                    Option option1 = _previewTrade.Spread.Options[0];
                    Option option2 = _previewTrade.Spread.Options[1];

                    if (option2.Strike > 0)
                        SwapOptions();
                    else
                    {
                        if(option1.PositionType == PositionType.Long)
                             UpdatePreviewTrade(exp,strike,opType,PositionType.Short, index);
                        else
                            UpdatePreviewTrade(exp, strike, opType, PositionType.Long, index);
                    }
                }
            }
        }

        private void Entered(DateTime exp, double strike, OptionType opType, PositionType posType, MouseEventArgs e)
        {
            Option optionEntered = new Option(_chain.Stock, opType, posType, strike, exp);
            int index = FindOptionIndex(exp, strike, opType);
            if (_dragIndex >= 0)
            {
                if (_dragIndex == 0 && _previewTrade.Spread.Options[1].Strike == 0 && _previewTrade.Spread.Options[_dragIndex].ExpirationDate == exp)
                {
                    UpdatePreviewTrade(exp, strike, opType, _previewTrade.Spread.Options[_dragIndex].PositionType, _dragIndex);
                    _dragIndex = -1;

                }
                else
                {
                    if (index < 0 && _previewTrade.Spread.Options[_dragIndex].ExpirationDate == exp)
                    {
                        UpdatePreviewTrade(exp, strike, opType, _previewTrade.Spread.Options[_dragIndex].PositionType, _dragIndex);
                        _dragIndex = -1;
                    }
                }
            }
        }

        private void MouseButtonUp(DateTime exp, double strike, OptionType opType, PositionType posType, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void MouseMoved(DateTime exp, double strike, OptionType opType, PositionType posType, MouseEventArgs e)
        {
            if(_mouseDown == false)
            {
                _dragIndex = -1;
            }
        }


        private int FindOptionIndex(DateTime exp, double strike , OptionType opType)
        {
            if (_previewTrade.Spread.Options[0].Strike == 0)
                return 0;
            if (_previewTrade.Spread.Options[0].Strike == strike && _previewTrade.Spread.Options[0].ExpirationDate == exp && _previewTrade.Spread.Options[0].OptionType == opType)
            {
                return 0;
            }
            else if (_previewTrade.Spread.Options[1].Strike == 0 && _previewTrade.Spread.Options[0].ExpirationDate == exp && _previewTrade.Spread.Options[0].OptionType == opType)
                return 1;
            else if (_previewTrade.Spread.Options[1].Strike == strike && _previewTrade.Spread.Options[1].ExpirationDate == exp && _previewTrade.Spread.Options[1].OptionType == opType)
            {
                return 1;
            }
            return -1;
        }

        private void UpdatePreviewTrade(Option option ,int optionIndex)
        {
            UpdatePreviewTrade(option.ExpirationDate, option.Strike, option.OptionType, option.PositionType, optionIndex);
        }

        private void UpdatePreviewTrade(DateTime exp, double strike, OptionType opType, PositionType posType, int optionIndex)
        {
            if (optionIndex >= 0 && optionIndex <= 1)
            {
                Option[] options = _previewTrade.Spread.Options;
                if (strike > 0 || optionIndex == 1)
                {
                    options[optionIndex] = new Option(_chain.Stock, opType, posType, strike, exp);
                    Spread newSpread = new Spread(options);
                    _previewTrade.Spread = newSpread;
                    SetTrade(_previewTrade);
                }
                else
                {
                    options[0] = options[1];
                    options[1] = new Option(_chain.Stock, opType, posType, strike, exp);
                    Spread newSpread = new Spread(options);
                    _previewTrade.Spread = newSpread;
                    if (_previewTrade.Spread.Options[1].Strike == 0)
                        _previewTrade.Amount = 1;
                    SetTrade(_previewTrade);
                }
            }
        }

        private void MoveExpandables(object sender, EventArgs args)
        {
            int totalHeight = 0;
            for (int i = 0; i < panelChain.Controls.Count; i++)
            {
                panelChain.Controls[i].Location = new Point(0, totalHeight);
                totalHeight += panelChain.Controls[i].Height + 2;
            }
        }
    }
}
