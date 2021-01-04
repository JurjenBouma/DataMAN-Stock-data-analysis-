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
    public class BuyAndManageLCV : IOptionTradeAlgorithm
    {
        public string Name { get { return "BuyAndManageLCV"; } }

        public async Task<OptionTradeList> Find(Stock stock, DateTime startDate, DateTime endDate)
        {
            OptionTradeList tradeList = new OptionTradeList(stock, Api.Interval.Daily);
            StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);

            int startIndex = data.FindDateIndex(startDate);
            int endIndex = data.FindDateIndex(endDate);

            int tradeHoldLenght = 30;
            double tradeHoldMaxGain = 0.9;
            double tradeHoldMaxLoss = -0.25;
            double portofolioPercentage = 0.8;

            bool inTrade = false;
            for (int i = startIndex; i <= endIndex; i++)
            {
                DateTime today = data.TimeSeries.DataPoints[i].DateTime;
                if (!inTrade)
                {
                    double close = data.TimeSeries.DataPoints[i].Close;
                    Spread spread = Spread.GetSpread(stock, SpreadType.LongCallVertical, close - close * 0.1, 5, today.AddDays(40), today);
                    OptionTrade trade = new OptionTrade
                    {
                        TradeDate = data.TimeSeries.DataPoints[i].DateTime,
                        PortfolioPercentage = portofolioPercentage,
                        Spread = spread
                    };
                    tradeList.Trades.Add(trade);
                    inTrade = true;
                }
                else
                {
                    OptionTrade lastTrade = tradeList.Trades[tradeList.Trades.Count - 1];
                    double openPrice = await lastTrade.Spread.Price(lastTrade.TradeDate);
                    double currentPrice = await lastTrade.Spread.Price(today);
                    double percentageGain = (currentPrice - openPrice) / openPrice;
                    int dateIndex = data.FindDateIndex(lastTrade.TradeDate);

                    if (i - dateIndex >= tradeHoldLenght || lastTrade.Spread.DaysUntilExpiration(today) < 5 || percentageGain > tradeHoldMaxGain || percentageGain < tradeHoldMaxLoss)
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
