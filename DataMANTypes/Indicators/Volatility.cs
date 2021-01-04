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
        public static double GetDailyVolatility(StockData data, int index, int period, PricePoint pricePoint)
        {
            double result = 0;
            if (index + 1 - period > 0)
            {
                int startIndex = index + 1 - period;
                int count = period;
                double[] nlogData = new double[period];

                for(int i = 0; i < nlogData.Length; i++)
                {
                    nlogData[i] = natLogReturn(data, startIndex + i, pricePoint);
                }

                double standardDev = GetStandardDeviation(nlogData);
                result = standardDev;
            }
            return result;
        }
        public static double GetAnualVolatility(StockData data, int index, int period, PricePoint pricePoint)
        {
            double result = 0;
            if (index + 1 - period > 0)
            {
                double dailyVol = GetDailyVolatility(data, index, period, pricePoint);
                result = dailyVol * Math.Sqrt(252);
            }
            return result;
        }

        private static double natLogReturn(StockData data, int index, PricePoint pricePoint)
        {
            double result = 0;
            if (index - 1 >= 0)
            {
                double priceI =1;
                double priceIPrev =1;

                switch (pricePoint)
                {
                    case PricePoint.Close:
                        priceI = data.TimeSeries.DataPoints[index].Close;
                        priceIPrev = data.TimeSeries.DataPoints[index -1].Close;
                        break;
                    case PricePoint.Low:
                        priceI = data.TimeSeries.DataPoints[index].Low;
                        priceIPrev = data.TimeSeries.DataPoints[index - 1].Low;
                        break;
                    case PricePoint.High:
                        priceI = data.TimeSeries.DataPoints[index].High;
                        priceIPrev = data.TimeSeries.DataPoints[index - 1].High;
                        break;
                    case PricePoint.Open:
                        priceI = data.TimeSeries.DataPoints[index].Open;
                        priceIPrev = data.TimeSeries.DataPoints[index - 1].Open;
                        break;
                }

                result = Math.Log(priceI / priceIPrev);
            }
            return result;
        }

        public static double GetStandardDeviation(double[] data)
        {
            double result = 0;
            double average = data.Average();
            double deviation;
            double deviationSqr;
            double sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                deviation = data[i] - average;
                deviationSqr = deviation * deviation;
                sum += deviationSqr;
            }
            result = Math.Sqrt(sum / (data.Length-1));

            return result;
        }


        /*public static double GetVolatility(StockData data, int index, int period, PricePoint pricePoint)
        {
            double result = 0;
            if (index + 1 - period >= 0)
            {
                int startIndex = index + 1 - period;
                int count = period;
                double[] priceData = new double[period];

                for (int i = 0; i < priceData.Length; i++)
                {
                    switch (pricePoint)
                    {
                        case PricePoint.Close:
                            priceData[i] = data.TimeSeries.DataPoints[startIndex + i].Close;
                            break;
                        case PricePoint.Low:
                            priceData[i] = data.TimeSeries.DataPoints[startIndex + i].Low;
                            break;
                        case PricePoint.High:
                            priceData[i] = data.TimeSeries.DataPoints[startIndex + i].High;
                            break;
                        case PricePoint.Open:
                            priceData[i] = data.TimeSeries.DataPoints[startIndex + i].Open;
                            break;
                    }
                }
                double standardDev = GetStandardDeviation(priceData);
                double lastPrice = 1;
                switch (pricePoint)
                {
                    case PricePoint.Close:
                        lastPrice = data.TimeSeries.DataPoints[index].Close;
                        break;
                    case PricePoint.Low:
                        lastPrice = data.TimeSeries.DataPoints[index].Low;
                        break;
                    case PricePoint.High:
                        lastPrice = data.TimeSeries.DataPoints[index].High;
                        break;
                    case PricePoint.Open:
                        lastPrice = data.TimeSeries.DataPoints[index].Open;
                        break;
                }
                result = standardDev / lastPrice;
            }
            return result;
        }*/
    }
}
