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
        public static class Api
        {
            public enum Interval
            {
                OneMinute = 0,
                FiveMinutes = 1,
                FifteenMinutes = 2,
                ThirtyMinutes = 3,
                Hourly = 4,
                Daily = 5,
                Weekly = 6,
                Monthly = 7
            }

            public enum Outputsize
            {
                compact, full
            }

            private static string _apiKey;
            private static bool _isInitialized = false;

            public static void Initialize(string apiKey)
            {
                _apiKey = apiKey;
                _isInitialized = true;
            }

            public static async Task<string> GetDataToFile(string symbol, Interval interval, Outputsize outputsize, string filePath)
            {
                string json = await GetData(symbol, interval, outputsize);
                string first100Chars = json.Substring(0, 100);
                if (json.Length > 0 && first100Chars.Contains("\"Meta Data\""))
                {
                    FileInfo file = new FileInfo(filePath);
                    if (!Directory.Exists(file.DirectoryName))
                        Directory.CreateDirectory(file.DirectoryName);
                    StreamWriter stream = new StreamWriter(new FileStream(filePath, FileMode.Create, FileAccess.Write));
                    stream.Write(json);
                    stream.Close();
                }
                return json;
            }

            public static async Task<string> GetData(string symbol, Interval interval, Outputsize outputsize)
            {
                APIParameter[] paramArray = GetParamArray(symbol, interval, outputsize);
                string result = await GetData(paramArray );
                return result;
            }

            private static async Task<string> GetData(APIParameter[] parameters)
            {
                if (_isInitialized)
                {
                    string request = @"https://www.alphavantage.co/query?";
                    foreach (APIParameter param in parameters)
                    {
                        request += param.ToAPIString();
                    }

                    request += "&apikey=" + _apiKey;

                    var apiData = await CallAlphaVantageApi(request);
                    //replace last refreshed
                    if (apiData.Length > 0)
                    {
                        int startIndex = apiData.IndexOf("Last Refreshed");
                        if (startIndex > 0)
                        {
                            int endIndex = apiData.IndexOf(",", startIndex);
                            string oldDateLine = apiData.Substring(startIndex, endIndex - startIndex);
                            string newDateLine = "Last Refreshed\": \"" + DateTime.UtcNow.ToString() + "\"";
                            apiData = apiData.Replace(oldDateLine, newDateLine);
                        }
                    }
                    return apiData;
                }
                return "";
            }

            private static async Task<string> CallAlphaVantageApi(string request)
            {
                try
                {
                    using (HttpClient client = new HttpClient())
                    {
                        string returnString = await client.GetStringAsync(request);
                        if (returnString.Contains("Invalid API call"))
                            return "";
                        return returnString;
                    }
                }
                catch
                {
                    return null;
                }
            }

            private static APIParameter[] GetParamArray(string symbol, Interval interval, Outputsize outputsize)
            {
                List<APIParameter> paramlist = new List<APIParameter>();
                if (interval <= Interval.Hourly)
                {
                    paramlist.Add(new APIParameter("function", "TIME_SERIES_INTRADAY"));
                    paramlist.Add(new APIParameter("symbol", symbol));
                    paramlist.Add(new APIParameter("interval", IntervalToAPIValue(interval)));
                    paramlist.Add(new APIParameter("outputsize", outputsize.ToString()));
                }
                else if (interval == Interval.Daily)
                {
                    paramlist.Add(new APIParameter("function", "TIME_SERIES_DAILY"));
                    paramlist.Add(new APIParameter("symbol", symbol));
                    paramlist.Add(new APIParameter("outputsize", outputsize.ToString()));
                }
                else if (interval == Interval.Weekly)
                {
                    paramlist.Add(new APIParameter("function", "TIME_SERIES_WEEKLY"));
                    paramlist.Add(new APIParameter("symbol", symbol));
                    paramlist.Add(new APIParameter("outputsize", outputsize.ToString()));
                }
                else if (interval == Interval.Monthly)
                {
                    paramlist.Add(new APIParameter("function", "TIME_SERIES_MONTHLY"));
                    paramlist.Add(new APIParameter("symbol", symbol));
                    paramlist.Add(new APIParameter("outputsize", outputsize.ToString()));
                }

                return paramlist.ToArray();
            }

            private static string IntervalToAPIValue(Interval interval)
            {
                switch (interval)
                {
                    case Interval.OneMinute:
                        return "1min";
                    case Interval.FiveMinutes:
                        return "5min";
                    case Interval.FifteenMinutes:
                        return "15min";
                    case Interval.ThirtyMinutes:
                        return "30min";
                    case Interval.Hourly:
                        return "60min";
                    default:
                        return "Null";

                }
            }

            private class APIParameter
            {
                public string Name;
                public string Value;

                public APIParameter(string name, string value)
                {
                    Name = name;
                    Value = value;
                }

                public string ToAPIString()
                {
                    return $"&{Name}={Value}";
                }
            }
        }
    }
}
