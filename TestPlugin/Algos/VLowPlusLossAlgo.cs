using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData;
using FinancialData.AlphaVantage;

namespace DataMAN
{
    public class VLowPlusLossAlgo : IStockTradeAlgorithm
    {
        public string Name { get { return "VLowPlusLoss"; } }

        public async Task<StockTradeList> Find(Stock stock, DateTime startDate, DateTime endDate)
        {
            StockTradeList tradeList = new StockTradeList(Api.Interval.Daily);
            StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);

            int startIndex = data.FindDateIndex(startDate);
            int period = 40;
            double priceGainGate = -0.5;
            double volumeGainGate = 0.5;

            int tradeHoldLenght = 15;
            double tradeHoldMaxGain = 0.04;
            double tradeHoldMaxLoss = -0.04;

            bool inTrade = false;
            for (int i = startIndex; i < data.TimeSeries.DataPoints.Count; i++)
            {
                if (!inTrade)
                {
                    {
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
                                StockTrade trade = new StockTrade
                                {
                                    DataIndex = i,
                                    PortfolioPercentage = 1,
                                    Stock = stock,
                                    Type = StockTradeType.LongStock
                                };
                                tradeList.Trades.Add(trade);
                                inTrade = true;
                            }
                        }
                    }
                }
                else
                {
                    StockTrade lastTrade = tradeList.Trades[tradeList.Trades.Count - 1];
                    double posOpen = data.TimeSeries.DataPoints[lastTrade.DataIndex].Close;
                    double currentPrice = data.TimeSeries.DataPoints[i].Close;
                    double percentageGain = (currentPrice - posOpen) / posOpen;

                    if (i - lastTrade.DataIndex >= tradeHoldLenght)
                    {
                        StockTrade trade = new StockTrade
                        {
                            DataIndex = i,
                            PortfolioPercentage = 0,
                            Stock = stock,
                            Type = StockTradeType.LongStock
                        };
                        tradeList.Trades.Add(trade);
                        inTrade = false;
                    }
                    else if (percentageGain > tradeHoldMaxGain || percentageGain < tradeHoldMaxLoss)
                    {
                        StockTrade trade = new StockTrade
                        {
                            DataIndex = i,
                            PortfolioPercentage = 0,
                            Stock = stock,
                            Type = StockTradeType.LongStock
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
