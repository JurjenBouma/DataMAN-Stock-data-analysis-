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
    public class OptionSimTest : IOptionTradeAlgorithm
    {
        public string Name { get { return "SimTest"; } }

        public async Task<OptionTradeList> Find(Stock stock, DateTime startDate, DateTime endDate)
        {
            OptionTradeList tradeList = new OptionTradeList(stock, Api.Interval.Daily);
            StockData data = await StockDataBase.Get(stock, Api.Interval.Daily);

            int startIndex = data.FindDateIndex(startDate);
            int endIndex = data.FindDateIndex(endDate);

            int tradeHoldLenght = 2;

            bool inTrade = false;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (!inTrade)
                {
                    Option[] options = new Option[2];
                    options[0] = new Option(stock, OptionType.Put, PositionType.Short, 230, startDate.AddDays(25));
                    options[1] = new Option(stock, OptionType.Put, PositionType.Long, 240, startDate.AddDays(25));
                    Spread spread = new Spread(options);
                    OptionTrade trade = new OptionTrade
                    {
                        TradeDate = data.TimeSeries.DataPoints[i].DateTime,
                        PortfolioPercentage = 1,
                        Spread = spread
                    };
                    tradeList.Trades.Add(trade);
                    inTrade = true;
                }
                else
                {
                    OptionTrade lastTrade = tradeList.Trades[tradeList.Trades.Count - 1];
                    int dateIndex = data.FindDateIndex(lastTrade.TradeDate);
                    if (i - dateIndex >= tradeHoldLenght)
                    {
                        OptionTrade trade = new OptionTrade
                        {
                            TradeDate = data.TimeSeries.DataPoints[i].DateTime,
                            PortfolioPercentage = 0,
                            Spread = lastTrade.Spread
                        };
                        tradeList.Trades.Add(trade);
                    }
                }

            }
            return tradeList;
        }
    }
}
