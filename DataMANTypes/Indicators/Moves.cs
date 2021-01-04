using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialData.AlphaVantage;
using System.IO;
using System.Drawing.Drawing2D;

namespace FinancialData
{
    public static partial class Indicators
    {
        public static class Moves
        {
            public static int[] FindMoves(StockData data, int startIndex, double threshold)
            {
                List<int> PointIndices = new List<int>();
                int dataCount = data.TimeSeries.DataPoints.Count;
                for (int i = startIndex; i < dataCount; i++)
                {
                    double open = data.TimeSeries.DataPoints[i].Open;
                    double close = data.TimeSeries.DataPoints[i].Close;

                    if (threshold > 0)
                        if (close - open >= open * threshold)
                            PointIndices.Add(i);

                    if (threshold < 0)
                        if (close - open <= open * threshold)
                            PointIndices.Add(i);
                }
                return PointIndices.ToArray();
            }

            public static int[] FindTurningPoints(StockData data, int startIndex, int SMAPeriod, PricePoint pricePoint)
            {
                List<int> PointIndices = new List<int>();
                int dataCount = data.TimeSeries.DataPoints.Count;
                double prevSMA = -1;
                double newSMA;
                int priceDir = 0;

                for (int i = startIndex; i < dataCount; i++)
                {
                    newSMA = Indicators.GetSMA(data, i, SMAPeriod, pricePoint);
                    if (prevSMA >= 0 && newSMA >= 0)
                    {
                        if (newSMA > prevSMA)
                        {
                            if (priceDir <= 0)
                            {
                                if (priceDir != 0)
                                    PointIndices.Add(i);
                                priceDir = 1;
                            }
                        }
                        else if (newSMA < prevSMA)
                        {
                            if (priceDir >= 0)
                            {
                                if (priceDir != 0)
                                    PointIndices.Add(i);
                                priceDir = -1;
                            }
                        }
                    }
                    prevSMA = newSMA;
                }
                return PointIndices.ToArray();
            }
        }
    }
}
