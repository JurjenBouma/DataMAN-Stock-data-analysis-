using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData.AlphaVantage;
using FinancialData;
using FinancialData.HistoricalOptionData;

namespace DataMAN
{
    public partial class SetupWindow : Form
    {
        public SetupWindow()
        {
            InitializeComponent();
        }

        private async void buttonStart_Click(object sender, EventArgs e)
        {
            TrainerWindow trainer = new TrainerWindow();
            DateTime startDate = dateTimePickerStart.Value;
            Stock stock = new Stock(textBoxStock.Text);
            if (checkBoxRandomStartDate.Checked)
            {
                Random r = new Random();
                int totalDays = (dateTimePickerStart.MaxDate - dateTimePickerStart.MinDate).Days;
                startDate = dateTimePickerStart.MinDate.AddDays(r.Next(0, totalDays- 90));
                StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);
                startDate = data.FindClosestTradeDay(startDate);
            }
            if (OptionChain.DataAvailible(stock, startDate))
            {
                trainer.Show((double)numericUpDown1.Value, startDate, new Stock(textBoxStock.Text));
                this.Close();
            }
        }

        private void checkBoxRandomStartDate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandomStartDate.Checked)
                dateTimePickerStart.Enabled = false;
            else
                dateTimePickerStart.Enabled = true;
        }
    }
}
