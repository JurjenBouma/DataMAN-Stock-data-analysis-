using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.IO;

namespace FinancialData
{
    namespace AlphaVantage
    {
        public class JsonConverter
        {
            public static StockData ConvertJsonFromFile(string file)
            {
                if (File.Exists(file))
                {
                    string json = File.ReadAllText(file);
                    return JObjectToAPIResult(JsonConvert.DeserializeObject<JObject>(json));
                }
                return null;
            }

            public static StockData ConvertJson(string json)
            {
                return JObjectToAPIResult(JsonConvert.DeserializeObject<JObject>(json));
            }

            public static StockData ConvertJson(JObject jObject)
            {
                return JObjectToAPIResult(jObject);
            }

            private static StockData JObjectToAPIResult(JObject jObject)
            {
                StockData result = new StockData();
                
                foreach (JProperty obj in (JToken)jObject)
                {
                    if (obj.Name == "Meta Data")
                    {
                        foreach (JProperty meta in obj.Values())
                        {
                            if (meta.Name.Contains("Information"))
                                result.MetaData.Information = meta.Value.ToString();
                            if (meta.Name.Contains("Symbol"))
                                result.MetaData.Symbol = meta.Value.ToString();
                            if (meta.Name.Contains("Last Refreshed"))
                                result.MetaData.LastRefreshed = meta.Value.ToString();
                            if (meta.Name.Contains("Output Size"))
                                result.MetaData.OutputSize = meta.Value.ToString();
                            if (meta.Name.Contains("Time Zone"))
                                result.MetaData.TimeZone = meta.Value.ToString();

                        }
                    }
                    if (obj.Name.Contains("Time Series"))
                    {
                        foreach (JProperty timeEntry in obj.Values())
                        {
                            StockDataPoint stockData = new StockDataPoint();
                            stockData.DateTime = DateTime.Parse(timeEntry.Name);
                            foreach (JProperty dataPoint in timeEntry.Values())
                            {
                                if (dataPoint.Name.Contains("open"))
                                    stockData.Open = Convert.ToDouble(dataPoint.Value.ToString());
                                if (dataPoint.Name.Contains("high"))
                                    stockData.High = Convert.ToDouble(dataPoint.Value.ToString());
                                if (dataPoint.Name.Contains("low"))
                                    stockData.Low = Convert.ToDouble(dataPoint.Value.ToString());
                                if (dataPoint.Name.Contains("close"))
                                    stockData.Close = Convert.ToDouble(dataPoint.Value.ToString());
                                if (dataPoint.Name.Contains("volume"))
                                    stockData.Volume = Convert.ToDouble(dataPoint.Value.ToString());
                            }
                            result.TimeSeries.DataPoints.Add(stockData);
                        }
                        result.TimeSeries.DataPoints.Reverse();
                    }
                }
                result = SetInterval(result);

                return result;
            }

            private static StockData SetInterval(StockData data)
            {
                StockData result = data;
                if (data != null)
                {
                    if (data.MetaData.Information.Contains("Intraday"))
                    {
                        if (data.MetaData.Information.Contains("1min"))
                            data.MetaData.Interval = Api.Interval.OneMinute;
                        else if (data.MetaData.Information.Contains("5min"))
                            data.MetaData.Interval = Api.Interval.FiveMinutes;
                        else if (data.MetaData.Information.Contains("15min"))
                            data.MetaData.Interval = Api.Interval.FifteenMinutes;
                        else if (data.MetaData.Information.Contains("30min"))
                            data.MetaData.Interval = Api.Interval.ThirtyMinutes;
                        else if (data.MetaData.Information.Contains("60min"))
                            data.MetaData.Interval = Api.Interval.Hourly;
                    }
                    else if (data.MetaData.Information.Contains("Daily"))
                        data.MetaData.Interval = Api.Interval.Daily;
                    else if (data.MetaData.Information.Contains("Weekly"))
                        data.MetaData.Interval = Api.Interval.Weekly;
                    else if (data.MetaData.Information.Contains("Monthly"))
                        data.MetaData.Interval = Api.Interval.Monthly;
                    
                    }
                return result;
            }
        }
    }
}
