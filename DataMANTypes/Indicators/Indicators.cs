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
    public enum PricePoint
    {
        Low, Close, Open, High, Volume
    }

    public static partial class Indicators
    {

        public static double GetSMA(StockData data, int index, int period, PricePoint pricePoint)
        {
            if (index + 1 - period >= 0)
                return GetAverage(data, index + 1 - period, period, pricePoint);
            else
                return -1;
        }

        public static double GetAverage(StockData data, int startIndex, int count, PricePoint pricePoint)
        {
            double result = 0;
            if (startIndex + count <= data.TimeSeries.DataPoints.Count)
            {
                for (int i = 0; i < count; i++)
                {
                    switch (pricePoint)
                    {
                        case PricePoint.Close:
                            result += data.TimeSeries.DataPoints[startIndex + i].Close;
                            break;
                        case PricePoint.Low:
                            result += data.TimeSeries.DataPoints[startIndex + i].Low;
                            break;
                        case PricePoint.High:
                            result += data.TimeSeries.DataPoints[startIndex + i].High;
                            break;
                        case PricePoint.Open:
                            result += data.TimeSeries.DataPoints[startIndex + i].Open;
                            break;
                        case PricePoint.Volume:
                            result += data.TimeSeries.DataPoints[startIndex + i].Volume;
                            break;
                    }
                }
                result /= count;
            }
            return result;
        }

        public static double GetStockAlpha(StockData data, int startIndex, int count)
        {
            double alpha = 0;
            if (startIndex + count <= data.TimeSeries.DataPoints.Count)
            {
                double startPrice = data.TimeSeries.DataPoints[startIndex].Close;
                double endPrice = data.TimeSeries.DataPoints[startIndex + count-1].Close;
                alpha = endPrice / startPrice;
            }
            return alpha;
        }
    }
}