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
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    public partial class OptionChainDateExpandable : UserControl
    {
        public delegate void ClickedHandler(DateTime exp , double strike, OptionType type ,PositionType posType , MouseEventArgs e);
        public ClickedHandler Clicked;
        public ClickedHandler DoubleClicked;
        public ClickedHandler Entered;
        public ClickedHandler MouseButtonUp;
        public ClickedHandler MouseMoved;

        private bool _showDate = true;
        private DateTime _experation;
        private DateTime _dataDate;
        private bool _expanded = false;
        private double[] _strikes;

        public OptionChainDateExpandable(OptionChain dateChain , bool showDate)
        {
            _showDate = showDate;
            InitializeComponent();
            Fill(dateChain);
        }

        public OptionChainDateExpandable(OptionChain dateChain)
        {
            InitializeComponent();
            Fill(dateChain);
        }

        public void Fill(OptionChain dateChain)
        {
            _experation = dateChain.Options[0].Experation;
            _dataDate = dateChain.Options[0].DataDate;
            _strikes = dateChain.Strikes();
            FillPanelChain(dateChain);
            FillLabels(dateChain);
            AddPriceLine(dateChain);
        }

        public void ShowTrade(OptionTrade trade)
        {
            if (trade.Spread.Options.Length > 0)
            {
                foreach (Control c in panelChain.Controls)
                {
                    if (c is OptionChainStrikeLine)
                    {
                        ((OptionChainStrikeLine)c).ShowTrade(trade);
                    }
                }
            }
        }

        public void ClearSelection()
        {
            foreach (Control c in panelChain.Controls)
            {
                if (c is OptionChainStrikeLine)
                {
                    ((OptionChainStrikeLine)c).ShowTrade(new OptionTrade());
                }
            }
        }

        private void AddPriceLine(OptionChain dateChain)
        {
            if (dateChain.Options.Count > 0)
            {
                double stockPrice = dateChain.StockPrice;
                for (int i = 1; i < _strikes.Length; i++)
                {
                    if(stockPrice <= _strikes[i] && stockPrice >= _strikes[i -1])
                    {
                        Panel priceLine = new Panel();
                        priceLine.BackColor = Color.BlanchedAlmond;
                        priceLine.Width = 920;
                        priceLine.Height = 10;
                        priceLine.Location = new Point(0, 32 * i-10);
                        panelChain.Controls.Add(priceLine);
                        break;
                    }
                }
            }
        }

        private void FillPanelChain(OptionChain dateChain)
        {
            panelChain.Controls.Clear();
            if (dateChain.Options.Count > 0)
            {
                for (int i = 0; i < _strikes.Length; i++)
                {
                    OptionChainDataPoint call = dateChain.FindOption(Options.OptionType.Call, _experation, _strikes[i]);
                    OptionChainDataPoint put = dateChain.FindOption(Options.OptionType.Put, _experation, _strikes[i]);
                    OptionChainStrikeLine line = new OptionChainStrikeLine(call, put);
                    line.Location = new Point(0, 32 * i);

                    line.CallClicked += new MouseEventHandler(FireCallClickEvent);
                    line.PutClicked += new MouseEventHandler(FirePutClickEvent);
                    line.CallDoubleClicked += new MouseEventHandler(FireCallDoubleClickEvent);
                    line.PutDoubleClicked += new MouseEventHandler(FirePutDoubleClickEvent);
                    line.CallEntered += new EventHandler(FireCallEnteredEvent);
                    line.PutEntered += new EventHandler(FirePutEnteredEvent);
                    line.CallMouseUp += new MouseEventHandler(FireCallMouseUpEvent);
                    line.PutMouseUp += new MouseEventHandler(FirePutMouseUpEvent);
                    line.CallMouseMove += new MouseEventHandler(FireCallMouseMoveEvent);
                    line.PutMouseMove += new MouseEventHandler(FirePutMouseMoveEvent);

                    panelChain.Controls.Add(line);
                }
            }
        }

        private void FillLabels(OptionChain dateChain)
        {
            if (dateChain.Options.Count > 0)
            {
                if (_showDate)
                    labelDate.Text = _experation.ToString("MMMM dd yyyy");
                else
                    labelDate.Text = "";
                labelDaysOut.Text = (_experation - _dataDate).TotalDays.ToString();
            }
        }

        private void FireCallClickEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            Clicked?.Invoke(_experation, line.Strike , OptionType.Call ,line.CallType , e);
        }

        private void FirePutClickEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            Clicked?.Invoke(_experation, line.Strike, OptionType.Put, line.PutType, e);
        }

        private void FireCallDoubleClickEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            DoubleClicked?.Invoke(_experation, line.Strike,OptionType.Call, line.CallType, e);
        }

        private void FirePutDoubleClickEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            DoubleClicked?.Invoke(_experation, line.Strike, OptionType.Put, line.PutType, e);
        }

        private void FireCallEnteredEvent(object sender, EventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            Entered?.Invoke(_experation, line.Strike, OptionType.Call,  line.CallType, new MouseEventArgs(MouseButtons.None,0,0,0,0));
        }

        private void FirePutEnteredEvent(object sender, EventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            Entered?.Invoke(_experation, line.Strike, OptionType.Put, line.PutType, new MouseEventArgs(MouseButtons.None, 0, 0, 0, 0));
        }

        private void FireCallMouseUpEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            MouseButtonUp?.Invoke(_experation, line.Strike, OptionType.Call, line.CallType, e);
        }

        private void FirePutMouseUpEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            MouseButtonUp?.Invoke(_experation, line.Strike, OptionType.Put, line.PutType, e);
        }

        private void FireCallMouseMoveEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            MouseMoved?.Invoke(_experation, line.Strike, OptionType.Call, line.CallType, e);
        }

        private void FirePutMouseMoveEvent(object sender, MouseEventArgs e)
        {
            OptionChainStrikeLine line = (OptionChainStrikeLine)sender;
            MouseMoved?.Invoke(_experation, line.Strike, OptionType.Put, line.PutType, e);
        }

        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (value == true)
                    Expand();
                else
                    Collapse();
            }
        }

        public void Expand()
        {
            panelChain.Visible = true;
            labelCall.Visible = true;
            labelPut.Visible = true;
            labelExpandArrow.Text = "/\\";
            labelDaysOut.ForeColor = Color.FromArgb(80, 80, 80);
            _expanded = true;
        }

        public void Collapse()
        {
            panelChain.Visible = false;
            labelCall.Visible = false;
            labelPut.Visible = false;
            labelExpandArrow.Text = "\\/";
            labelDaysOut.ForeColor = Color.Black;
            _expanded = false;
        }

        private void labelExpandArrow_Click(object sender, EventArgs e)
        {
            if (_expanded)
                Collapse();
            else
                Expand();
        }
    }
}
