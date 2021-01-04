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
        private PluginControl UI;

        public string Name { get { return "Test Plugin"; } }

        public void Load(Panel controlPanel , Panel variablePanel)
        {
            panelControl = controlPanel;
            panelVariable = variablePanel;

            UI = new PluginControl();
            panelControl.Controls.Add(UI);
        }

        public void UnLoad()
        {
            panelControl.Controls.Clear();
            panelVariable.Controls.Clear();
        }
    }
}
