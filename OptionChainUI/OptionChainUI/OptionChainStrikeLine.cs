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
    public partial class OptionChainStrikeLine : UserControl
    {
        public double Strike;
        public DateTime Experation;
        public MouseEventHandler CallClicked;
        public MouseEventHandler PutClicked;
        public MouseEventHandler CallDoubleClicked;
        public MouseEventHandler PutDoubleClicked;
        public EventHandler CallEntered;
        public EventHandler PutEntered;
        public MouseEventHandler CallMouseUp;
        public MouseEventHandler PutMouseUp;
        public MouseEventHandler CallMouseMove;
        public MouseEventHandler PutMouseMove;
        public bool Clickable = true;
        public PositionType CallType { get { return _callType; } }
        public PositionType PutType { get { return _putType; } }

        private PositionType _callType = PositionType.Short;
        private PositionType _putType = PositionType.Short;

        public OptionChainStrikeLine(OptionChainDataPoint dataPointCall , OptionChainDataPoint dataPointPut)
        {
            InitializeComponent();
            labelStrike.Text = dataPointCall.Strike.ToString();

            labelVolumeCall.Text = dataPointCall.Volume.ToString();
            labelAskCall.Text = dataPointCall.Ask.ToString();
            labelBidCall.Text = dataPointCall.Bid.ToString();
            labelOpenInterestCall.Text = dataPointCall.OpenInterest.ToString();

            labelVolumePut.Text = dataPointPut.Volume.ToString();
            labelAskPut.Text = dataPointPut.Ask.ToString();
            labelBidPut.Text = dataPointPut.Bid.ToString();
            labelOpenInterestPut.Text = dataPointPut.OpenInterest.ToString();

            Strike = dataPointCall.Strike;
            Experation = dataPointCall.Experation;
        }

        public void ShowTrade(OptionTrade trade)
        {
            CallUnselect();
            PutUnselect();
            ClearProfitColors();
            if (trade.Spread != null)
            {
                if (trade.Spread.Options.Length > 0)
                    ViewOption(trade.Spread.Options[0]);

                if (trade.Spread.Options.Length > 1)
                    ViewOption(trade.Spread.Options[1]);

                ViewProfitColors(trade);
            }
        }

        private void ClearProfitColors()
        {
            labelStrike.BackColor = Color.FromArgb(120, 130, 130);
        }

        private async void ViewProfitColors(OptionTrade trade)
        {
            if(trade.Spread.ExpirationDate == Experation && trade.Spread.Options[0].Strike > 0)
            {
                double breakEven = await trade.Spread.BreakEven(trade.TradeDate);
                if (trade.Spread.ProfitDirection == -1)
                {
                    if(Strike <= breakEven)
                        labelStrike.BackColor = Color.Green;
                    else
                        labelStrike.BackColor = Color.Red;
                }
                if (trade.Spread.ProfitDirection == 1)
                {
                    if (Strike >= breakEven)
                        labelStrike.BackColor = Color.Green;
                    else
                        labelStrike.BackColor = Color.Red;
                }
            }
        }

        private void ViewOption(Option option)
        {
            if (option.Strike == Strike && option.ExpirationDate == Experation)
            {
                if (option.OptionType == OptionType.Call && option.PositionType == PositionType.Long)
                    ViewCallBuy();
                else if (option.OptionType == OptionType.Call && option.PositionType == PositionType.Short)
                    ViewCallSell();
                else if (option.OptionType == OptionType.Put && option.PositionType == PositionType.Long)
                    ViewPutBuy();
                else if (option.OptionType == OptionType.Put && option.PositionType == PositionType.Short)
                    ViewPutSell();
            }
        }

        private void ViewCallBuy()
        {
            _callType = PositionType.Long;
            SetCallLabelsColor(Color.FromArgb(0, 100, 10));
        }

        private void ViewCallSell()
        {
            _callType = PositionType.Short;
            SetCallLabelsColor(Color.FromArgb(100, 0, 10));
        }

        private void CallUnselect()
        {
            _callType = PositionType.Short;
            SetCallLabelsColor(Color.FromArgb(64, 64, 64));
        }

        private void SetCallLabelsColor(Color color)
        {
            labelAskCall.BackColor = color;
            labelBidCall.BackColor = color;
            labelOpenInterestCall.BackColor = color;
            labelVolumeCall.BackColor = color;
        }

        private void ViewPutBuy()
        {
            _putType = PositionType.Long;
            SetPutLabelsColor(Color.FromArgb(0, 100, 10));
        }

        private void ViewPutSell()
        {
            _putType = PositionType.Short;
            SetPutLabelsColor(Color.FromArgb(100, 0, 10));
        }

        private void PutUnselect()
        {
            _putType = PositionType.Short;
            SetPutLabelsColor(Color.FromArgb(64, 64, 64));
        }

        private void SetPutLabelsColor(Color color)
        {
            labelAskPut.BackColor = color;
            labelBidPut.BackColor = color;
            labelOpenInterestPut.BackColor = color;
            labelVolumePut.BackColor = color;
        }

        private void FireCallClickEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                CallClicked?.Invoke(this, e);
            }
        }

        private void FirePutClickEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                PutClicked?.Invoke(this, e);
            }
        }

        private void FireCallDoubleClickEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                CallDoubleClicked?.Invoke(this, e);
            }
        }

        private void FirePutDoubleClickEvent(object sender,MouseEventArgs e)
        {
            if (Clickable)
            {
                PutDoubleClicked?.Invoke(this, e);
            }
        }

        private void FireCallEnteredEvent(object sender, EventArgs e)
        {
            if (Clickable)
            {
                CallEntered?.Invoke(this, e);
            }
        }

        private void FirePutEnteredEvent(object sender, EventArgs e)
        {
            if (Clickable)
            {
                PutEntered?.Invoke(this, e);
            }
        }

        private void FireCallMouseUpEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                CallMouseUp?.Invoke(this, e);
            }
        }

        private void FirePutMouseUpEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                PutMouseUp?.Invoke(this, e);
            }
        }

        private void FireCallMouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                CallMouseMove?.Invoke(this, e);
            }
        }

        private void FirePutMouseMoveEvent(object sender, MouseEventArgs e)
        {
            if (Clickable)
            {
                PutMouseMove?.Invoke(this, e);
            }
        }
    }
}
