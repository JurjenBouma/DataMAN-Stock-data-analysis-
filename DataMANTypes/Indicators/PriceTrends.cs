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
    public enum PriceTrend
    {
        Up, Flat, Down
    }

    public static partial class Indicators
    {
        public static class PriceTrends
        {
            public static int GetTrendLength(StockData data, int index, int minPeriod)
            {
                PriceTrend trend = GetPriceTrend(data, index, minPeriod);
                int i = 1;
                while (trend == GetPriceTrend(data, index, minPeriod + i))
                {
                    i++;
                    if (index + 1 - minPeriod - i < 0)
                        break;
                }
                i--;

                return minPeriod + i;
            }

            public static PriceTrend GetPriceTrend(StockData data, int index, int period)
            {
                int startIndex = index + 1 - period;
                PriceTrend result = PriceTrend.Flat;
                if (startIndex >= 0)
                {
                    PriceTrend highTrend = GetTrend(data, index, period, PricePoint.High);
                    PriceTrend lowTrend = GetTrend(data, index, period, PricePoint.Low);

                    if (highTrend == PriceTrend.Up && lowTrend == PriceTrend.Up)
                        result = PriceTrend.Up;
                    if (highTrend == PriceTrend.Down && lowTrend == PriceTrend.Down)
                        result = PriceTrend.Down;
                }
                return result;
            }

            private static PriceTrend GetTrend(StockData data, int index, int period, PricePoint pricePoint)
            {
                int startIndex = index + 1 - period;
                PriceTrend result = PriceTrend.Flat;
                if (startIndex >= 0)
                {
                    int sectorCount = 3;
                    int sectorSize = period / sectorCount;
                    double[] sectorSMAs = new double[sectorCount];
                    int remaininglastSector = period % sectorSize;

                    //get sector SMAs
                    for (int i = 0; i < sectorCount; i++)
                    {
                        switch (pricePoint)
                        {
                            case PricePoint.Close:
                                sectorSMAs[i] = GetAverage(data, startIndex + i * sectorSize, sectorSize + remaininglastSector, PricePoint.Close);
                                break;
                            case PricePoint.Low:
                                sectorSMAs[i] = GetAverage(data, startIndex + i * sectorSize, sectorSize + remaininglastSector, PricePoint.Low);
                                break;
                            case PricePoint.High:
                                sectorSMAs[i] = GetAverage(data, startIndex + i * sectorSize, sectorSize + remaininglastSector, PricePoint.High);
                                break;
                            case PricePoint.Open:
                                sectorSMAs[i] = GetAverage(data, startIndex + i * sectorSize, sectorSize + remaininglastSector, PricePoint.Open);
                                break;
                        }

                    }

                    //compare sector SMAs
                    double lastSMA = sectorSMAs[0];
                    bool isUp = true;
                    bool isDown = true;
                    for (int i = 1; i < sectorCount; i++)
                    {
                        if (sectorSMAs[i] < lastSMA)
                            isUp = false;
                        if (sectorSMAs[i] > lastSMA)
                            isDown = false;
                        lastSMA = sectorSMAs[i];
                    }
                    if (isUp)
                        result = PriceTrend.Up;
                    if (isDown)
                        result = PriceTrend.Down;
                }
                return result;
            }


            /*public static PriceTrend GetHighTrend(StockData data, int index, int period)
            {
                int startIndex = index + 1 - period;
                PriceTrend result = PriceTrend.Flat;
                if (startIndex >= 0)
                {
                    int sectorSize = period / 3;
                    int smaDevider = 100000;
                    int smaPeriod =  1 + period / smaDevider;
                    double firstHigh = -1;
                    double secondHigh = -1;
                    double thirdHigh = -1;

                    int remaininglastSector = period % smaPeriod;
                    for (int i = 0; i < period - remaininglastSector; i++)
                    {
                        if (i < sectorSize)
                        {
                            if (firstHigh < GetAverage(data, startIndex + i, smaPeriod, PricePoint.High))
                                firstHigh = GetAverage(data, startIndex + i, smaPeriod, PricePoint.High);
                        }
                        if (i >= sectorSize && i <= period - sectorSize)
                        {
                            if (secondHigh < GetAverage(data, startIndex + i, smaPeriod, PricePoint.High))
                                secondHigh = GetAverage(data, startIndex + i, smaPeriod, PricePoint.High);
                        }
                        if (i > period - sectorSize)
                        {
                            if (thirdHigh < GetAverage(data, startIndex + i, smaPeriod, PricePoint.High))
                                thirdHigh = GetAverage(data, startIndex + i, smaPeriod, PricePoint.High);
                        }
                    }
                    if (remaininglastSector > 0)
                    {
                        if (thirdHigh < GetAverage(data, startIndex + period - remaininglastSector, remaininglastSector, PricePoint.High))
                            thirdHigh = GetAverage(data, startIndex + period - remaininglastSector, remaininglastSector, PricePoint.High);
                    }


                if (firstHigh <= secondHigh && secondHigh <= thirdHigh)
                        result = PriceTrend.Up;
                    else if(firstHigh >= secondHigh && secondHigh >= thirdHigh)
                        result = PriceTrend.Down;

                }
                return result;
            }

            public static PriceTrend GetLowTrend(StockData data, int index, int period)
            {
                int startIndex = index + 1 - period;
                PriceTrend result = PriceTrend.Flat;
                if (startIndex >= 0)
                {
                    int sectorSize = period / 3;
                    int smaDevider = 100000;
                    int smaPeriod = 1 + period / smaDevider;
                    double firstLow = double.MaxValue;
                    double secondLow = double.MaxValue;
                    double thirdLow = double.MaxValue;
                    int remaininglastSector = period % smaPeriod;

                    for (int i = 0; i < period - remaininglastSector; i++)
                    {
                        if (i < sectorSize)
                        {
                            if (firstLow > GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low))
                                firstLow = GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low);
                        }
                        if (i >= sectorSize && i <= period - sectorSize)
                        {
                            if (secondLow > GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low))
                                secondLow = GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low);
                        }
                        if (i > period - sectorSize)
                        {
                            if (thirdLow > GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low))
                                thirdLow = GetAverage(data, startIndex + i, smaPeriod, PricePoint.Low);
                        }
                    }
                    if (remaininglastSector > 0)
                    {
                        if (thirdLow > GetAverage(data, startIndex + period - remaininglastSector, remaininglastSector, PricePoint.Low))
                            thirdLow = GetAverage(data, startIndex + period - remaininglastSector, remaininglastSector, PricePoint.Low);
                    }


                    if (firstLow <= secondLow && secondLow <= thirdLow)
                        result = PriceTrend.Up;
                    else if (firstLow >= secondLow && secondLow >= thirdLow)
                        result = PriceTrend.Down;

                }
                return result;
            }*/
        }
    }
}