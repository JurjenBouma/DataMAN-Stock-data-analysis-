using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData.AlphaVantage;
using System.Windows.Forms;
using FinancialData;

namespace DataMAN
{
    public static class GlobalObjects
    {
        public static Chart Chart;
        public static void Initialize()
        {
            Chart = new Chart();
        }
    }
}
