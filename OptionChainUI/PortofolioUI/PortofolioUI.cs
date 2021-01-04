using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMAN.PortofolioUI
{
    public partial class PortofolioUI : UserControl
    {
        public PortofolioUI()
        {
            InitializeComponent();
        }

        public void SetValues(double cash, double portfolioValue)
        {
            labelCashValue.Text = cash.ToString();
            labelPortfolioValue.Text = portfolioValue.ToString();
        }
    }
}
