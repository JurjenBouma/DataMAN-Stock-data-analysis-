using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using FinancialData.AlphaVantage;

namespace DataMAN
{
    public class Plugin : IAnalizer
    {
        private Panel panelControl;
        private Panel panelVariable;
        private SetupWindow SetupWindow;

        public string Name { get { return "Trainer Daytrade"; } }

        public void Load(Panel controlPanel, Panel variablePanel)
        {
            panelControl = controlPanel;
            panelVariable = variablePanel;

            SetupWindow = new SetupWindow();
            SetupWindow.Show();
        }

        public void UnLoad()
        {
            SetupWindow.Hide();
            panelControl.Controls.Clear();
            panelVariable.Controls.Clear();
        }
    }
}
