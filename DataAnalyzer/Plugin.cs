using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData;
using DataMAN.Options;
using FinancialData.AlphaVantage;
using System.IO;
using System.Threading;

namespace DataMAN
{
    public class Plugin : IAnalizer
    {
        private Panel panelControl;
        private Panel panelVariable;

        public string Name { get { return "Analize Data"; } }

        public async void Load(Panel controlPanel, Panel variablePanel)
        {
            panelControl = controlPanel;
            panelVariable = variablePanel;

            Option option = Option.GetOption(new Stock("MSFT"), OptionType.Call, PositionType.Long, 45, new DateTime(2015, 08, 01), new DateTime(2015, 06, 01));
            GraphData priceGraph = await PositionPriceGrapher.PriceGraph(new DateTime(2015, 06, 01), option);
            GlobalObjects.Chart.Graphs.Add(priceGraph);
        }

        public void UnLoad()
        {
            panelControl.Controls.Clear();
            panelVariable.Controls.Clear();
        }
    }
}
