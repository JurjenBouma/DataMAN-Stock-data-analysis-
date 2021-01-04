using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;


namespace FinancialData
{
    namespace AlphaVantage
    {
        public class StockData
        {
            public MetaData MetaData;
            public TimeSeries TimeSeries;

            public StockData()
            {
                MetaData = new MetaData();
                TimeSeries = new TimeSeries();
            }

            public int FindDateIndex(DateTime date)
            {
                int index = -1;

                int dataCount = TimeSeries.DataPoints.Count;
                for (int i = 0; i < dataCount; i++)
                {
                    if (TimeSeries.DataPoints[i].DateTime >= date)
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    index = 0;
                return index;
            }

            public DateTime FindClosestTradeDay(DateTime date)
            {
                int index = FindDateIndex(date);
                return TimeSeries.DataPoints[index].DateTime;
            }
        }

        public class MetaData
        {
            public string Information = "";
            public string Symbol = "";
            public string LastRefreshed = "";
            public Api.Interval Interval;
            public string OutputSize = "";
            public string TimeZone = "";
        }

        public class TimeSeries
        {
            public List<StockDataPoint> DataPoints;

            public TimeSeries()
            {
                DataPoints = new List<StockDataPoint>();
            }
        }

        public class StockDataPoint
        {
            public DateTime DateTime;
            public double Open;
            public double High;
            public double Low;
            public double Close;
            public double Volume;

            public StockDataPoint() { }
            public StockDataPoint(DateTime dateTime, double open, double high, double low, double close, double volume)
            {
                DateTime = dateTime;
                Open = open;
                High = high;
                Low = low;
                Close = close;
                Volume = volume;
            }
        }
    }
}
