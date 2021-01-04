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
using DataMAN.Options;

namespace FinancialData
{
    public static partial class Indicators
    {
        public static class Options
        {
            private static int VolatilityPeriod = 5;

            public static double AproxPrice(StockData data, int index, OptionType type ,double strike, int expiration)
            {
                VolatilityPeriod = Math.Max(50, expiration);

                double priceATM = ATMPricePercent(data, index, expiration);
                double deltaATM = 0;
                switch (type)
                {
                    case OptionType.Call:
                        deltaATM = ATMCallDelta(data, index, expiration);
                        break;
                    case OptionType.Put:
                        deltaATM = ATMPutDelta(data, index, expiration);
                        break;
                }
                double gammaATM = ATMGamma(data, index, expiration);
                double stockPrice = data.TimeSeries.DataPoints[index].Close;
                double percentFromStrike = stockPrice / strike - 1;

                double delta = deltaATM * percentFromStrike;
                double gamma = 0.5 * gammaATM * Math.Pow(percentFromStrike, 2);
                double callPricePercent = priceATM + delta + gamma;


                if (delta < 0)
                {
                    double deltaPlus = -1*(Math.Abs(deltaATM) * (Math.Abs(percentFromStrike) + 0.0001));
                    double gammaPlus = 0.5 * gammaATM * Math.Pow(Math.Abs(percentFromStrike) + 0.0001, 2);
                    double callPricePercentPlus = priceATM + deltaPlus + gammaPlus;
                    if (callPricePercentPlus > callPricePercent)
                        return 0;
                }

                double price = stockPrice * callPricePercent;

                if (expiration <= 0)
                {
                    switch (type)
                    {
                        case OptionType.Call:
                            price = stockPrice - strike;
                            break;
                        case OptionType.Put:
                            price = strike - stockPrice;
                            break;
                    }
                }
                if (price < 0)
                    price = 0;

                return price;
            }

            private static double ATMGamma(StockData data, int index, int expiration)
            {
                double volatility = GetAnualVolatility(data, index, VolatilityPeriod, PricePoint.Close);
                double timeSqrt = Math.Sqrt(expiration / 365f);

                return 0.4 /(volatility * timeSqrt);
            }


            private static double ATMPutDelta(StockData data, int index, int expiration)
            {
                double callDelta = ATMCallDelta(data, index, expiration);
                return callDelta - 1;
            }

            private static double ATMCallDelta(StockData data, int index, int expiration)
            {
                double volatility = GetAnualVolatility(data, index, VolatilityPeriod, PricePoint.Close);
                double timeSqrt = Math.Sqrt(expiration / 365f);

                return 0.5 + 0.2 * volatility * timeSqrt;
            }

            private static double ATMPricePercent(StockData data, int index, int expiration)
            {
                double volatility = GetAnualVolatility(data, index, VolatilityPeriod, PricePoint.Close);
                double timeSqrt = Math.Sqrt(expiration / 365f);

                return volatility * 0.4 * timeSqrt;
            }
        }
    }
}

