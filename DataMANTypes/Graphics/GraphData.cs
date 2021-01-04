using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using FinancialData.AlphaVantage;
using System.Windows.Forms;

namespace DataMAN
{
    public class GraphDataPoint
    {
        public DateTime DateTime;
        public double GraphData;

        public GraphDataPoint (DateTime dateTime , double graphData)
        {
            DateTime = dateTime;
            GraphData = graphData;
        }
    }

    public class GraphData
    {
        public string Name { get { return _name; } }
        public List<GraphDataPoint> DataPoints;

        private string _name;
        public GraphData(string name)
        {
            _name = name;
            DataPoints = new List<GraphDataPoint>();
        }

        public int FindDateIndex(DateTime date)
        {
            int index = -1;

            int dataCount = DataPoints.Count;
            for (int i = 0; i < dataCount; i++)
            {
                if (index < 0 && DataPoints[i].DateTime >= date)
                    index = i;
            }
            if (index < 0)
                index = 0;
            return index;
        }
    }
}
