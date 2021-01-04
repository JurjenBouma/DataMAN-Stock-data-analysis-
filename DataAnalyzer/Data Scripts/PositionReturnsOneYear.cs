using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinancialData;
using FinancialData.AlphaVantage;
using DataMAN.Options;
using FinancialData.HistoricalOptionData;
using System.IO;

namespace DataMAN
{
    public static class PositionPriceGrapher
    {
        public async static Task<GraphData> PriceGraph(DateTime openDate , Option option)
        {
            StockData data = await StockDataBase.Get(option.Stock, Api.Interval.Daily);
            int startIndex = data.FindDateIndex(openDate);
            int endIndex = data.FindDateIndex(option.ExpirationDate);

            GraphData graph = new GraphData("PriceGraph " + option.Stock.StockSymbol + " " + option.Strike.ToString() + option.OptionType.ToString());

            for (int i = startIndex; i <= endIndex; i++)
            {
                DateTime dataPointDate = data.TimeSeries.DataPoints[i].DateTime;
                Option opt = Option.GetOption(option.Stock, option.OptionType, option.PositionType, option.Strike, option.ExpirationDate, dataPointDate);
                double price = await opt.Price(dataPointDate);
                GraphDataPoint point = new GraphDataPoint(dataPointDate, price);
                graph.DataPoints.Add(point);
            }

            return graph;
        }
  
    }
}
