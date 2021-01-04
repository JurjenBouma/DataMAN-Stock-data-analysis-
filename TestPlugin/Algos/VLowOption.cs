using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData;
using FinancialData.AlphaVantage;
using DataMAN.Options;

namespace DataMAN
{
    public class VLowOption : IOptionTradeAlgorithm
    {
        public string Name { get { return "Low Volume"; } }

        public async Task<OptionTradeList> Find(Stock stock, DateTime startDate, DateTime endDate)
        {
            OptionTradeList tradeList = new OptionTradeList(stock, Api.Interval.Daily);
            StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);

            int startIndex = data.FindDateIndex(startDate);
            int endIndex = data.FindDateIndex(endDate);

            int period = 40;
            double priceGainGate = -0.5;
            double volumeGainGate = 0.5;

            int tradeHoldLenght = 15;
            double tradeHoldMaxGain = 0.9;
            double tradeHoldMaxLoss = -0.25;
            double portofolioPercentage = 0.8;

            bool inTrade = false;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (!inTrade)
                {
                    {
                        DateTime today = data.TimeSeries.DataPoints[i].DateTime;
                        double open = data.TimeSeries.DataPoints[i].Open;
                        double close = data.TimeSeries.DataPoints[i].Close;
                        double percentageGain = (close - open) / open;
                        if (percentageGain > priceGainGate)
                        {
                            double volume = data.TimeSeries.DataPoints[i].Volume;
                            double volumeSMA = Indicators.GetSMA(data, i, period, PricePoint.Volume);
                            double volumePercentageGain = (volume - volumeSMA) / volumeSMA;
                            if (volumePercentageGain > volumeGainGate)
                            {
                                Option[] options = new Option[2];
                                options[0] = new Option(stock, OptionType.Call, PositionType.Long, Math.Round(close,0) - 5, today.AddDays(40));
                                options[1] = new Option(stock, OptionType.Call, PositionType.Short, Math.Round(close, 0) + 0, today.AddDays(40));
                                Spread spread = new Spread(options);
                                OptionTrade trade = new OptionTrade
                                {
                                    TradeDate = data.TimeSeries.DataPoints[i].DateTime,
                                    PortfolioPercentage = portofolioPercentage,
                                    Spread = spread
                                };
                                tradeList.Trades.Add(trade);
                                inTrade = true;
                            }
                        }
                    }
                }
                else
                {
                    OptionTrade lastTrade = tradeList.Trades[tradeList.Trades.Count - 1];
                    DateTime today = data.TimeSeries.DataPoints[i].DateTime;
                    int dateIndex = data.FindDateIndex(lastTrade.TradeDate);
                    double openPrice = await lastTrade.Spread.Price(lastTrade.TradeDate);
                    double currentPrice = await lastTrade.Spread.Price(today);
                    double percentageGain = (currentPrice - openPrice) / openPrice;

                    if (i - dateIndex >= tradeHoldLenght || lastTrade.Spread.DaysUntilExpiration(today) <5 || percentageGain > tradeHoldMaxGain || percentageGain < tradeHoldMaxLoss)
                    {
                        OptionTrade trade = new OptionTrade
                        {
                            TradeDate = data.TimeSeries.DataPoints[i].DateTime,
                            PortfolioPercentage = 0,
                            Spread = lastTrade.Spread
                        };
                        tradeList.Trades.Add(trade);
                        inTrade = false;
                    }
                }
            }
            return tradeList;
        }
    }
}
