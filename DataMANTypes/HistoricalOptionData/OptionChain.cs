using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using DataMAN;
using DataMAN.Options;

namespace FinancialData
{
    namespace HistoricalOptionData
    {
        public class OptionChain
        {
            public DateTime DataDate;
            public Stock Stock;
            public List<OptionChainDataPoint> Options;

            public OptionChain(Stock stock , DateTime dataDate)
            {
                DataDate = dataDate;
                Stock = stock;
                Options = new List<OptionChainDataPoint>();
            }
            public OptionChain(Stock stock, DateTime dataDate , List<OptionChainDataPoint> options)
            {
                DataDate = dataDate;
                Stock = stock;
                Options = options;
            }

            public static OptionChain LoadChainFromFile(Stock stock, DateTime dateDate)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\Financial data\\Options\\HistoricalOptionData\\"
                   + stock.StockSymbol + "\\" + stock.StockSymbol + "_" + dateDate.ToString("yyyy/MM/dd") + ".csv";
                if (File.Exists(filePath))
                {
                    OptionFile optionFile = new OptionFile(filePath);
                    return optionFile.Load();
                }
                return null;
            }

            public static bool DataAvailible(Stock stock, DateTime dateDate)
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\DataMAN\\Financial data\\Options\\HistoricalOptionData\\"
                  + stock.StockSymbol + "\\" + stock.StockSymbol + "_" + dateDate.ToString("yyyy/MM/dd") + ".csv";

                if (File.Exists(filePath) && File.ReadAllText(filePath).Length > 0)
                    return true;
                else
                    return false;
            }

            public DateTime FindClosestExperation(DateTime experationDate)
            {
                DateTime closestExperation = Options[0].Experation;
                long closestDifference = Math.Abs(closestExperation.Ticks - experationDate.Ticks);
                for (int i = 0; i < Options.Count; i++)
                {
                    if (Math.Abs(Options[i].Experation.Ticks - experationDate.Ticks) < closestDifference)
                    {
                        closestExperation = Options[i].Experation;
                        closestDifference = Math.Abs(closestExperation.Ticks - experationDate.Ticks);
                        if (closestExperation == experationDate)
                            break;
                    }
                }
                return closestExperation;
            }

            public DateTime[] Experations()
            {
                List<DateTime> ExperationList = new List<DateTime>();

                for (int i = 0; i < Options.Count; i++)
                {
                    DateTime experation = Options[i].Experation;
                    if (!ExperationList.Contains(experation))
                        ExperationList.Add(experation);
                }
                ExperationList = ExperationList.OrderBy(x => x).ToList<DateTime>();
                return ExperationList.ToArray();
            }

            public double FindClosestStrike(double strike , DateTime experationDate)
            {
                DateTime closestExperation = FindClosestExperation(experationDate);
                double closestStrike = -1;
                double closestDifference = Math.Abs(closestStrike - strike);
                OptionChain subChain = SubChain(closestExperation);

                for (int i = 0; i < subChain.Options.Count; i++)
                {
                    if (Math.Abs(subChain.Options[i].Strike - strike) < closestDifference)
                    {
                        closestStrike = subChain.Options[i].Strike;
                        closestDifference = Math.Abs(closestStrike - strike);
                        if (closestStrike == strike)
                            break;
                    }
                }
                return closestStrike;
            }

            public double FindNextLowerStrike(double strike, DateTime experationDate)
            {
                DateTime closestExperation = FindClosestExperation(experationDate);
                double closestStrike = FindClosestStrike(strike, experationDate);
                OptionChain subChain = SubChain(closestExperation);
                double nextStrike = 0;

                for (int i = 0; i < subChain.Options.Count; i++)
                {
                    double strikeDifference = subChain.Options[i].Strike - closestStrike;
                    if (strikeDifference < 0 && subChain.Options[i].Strike > nextStrike)
                    {
                        nextStrike = subChain.Options[i].Strike;
                    }
                }
 
                return nextStrike;
            }

            public double FindNextStrike(double strike, DateTime experationDate)
            {
                DateTime closestExperation = FindClosestExperation(experationDate);
                double closestStrike = FindClosestStrike(strike, experationDate);
                OptionChain subChain = SubChain(closestExperation);
                double nextStrike = double.MaxValue;

                for (int i = 0; i < subChain.Options.Count; i++)
                {
                    double strikeDifference = subChain.Options[i].Strike - closestStrike;
                    if (strikeDifference > 0 && subChain.Options[i].Strike < nextStrike)
                    {
                        nextStrike = subChain.Options[i].Strike;
                    }
                }
                if (nextStrike == double.MaxValue)
                    nextStrike = 0;
                return nextStrike;
            }

            public double[] Strikes()
            {
                List<double> strikeList = new List<double>();

                for (int i = 0; i < Options.Count; i++)
                {
                    double strike = Options[i].Strike;
                    if (!strikeList.Contains(strike))
                        strikeList.Add(strike);
                }
                strikeList = strikeList.OrderBy(x => x).ToList<double>();
                return strikeList.ToArray();
            }

            public OptionChainDataPoint FindOption(OptionType type, DateTime experationDate, double strike)
            {
                DateTime closestExperation = FindClosestExperation(experationDate);
                double closestStrike = FindClosestStrike(strike, closestExperation);
                int index = -1;

                for (int i = 0; i < Options.Count; i++)
                {
                    if (Options[i].Type == type && Options[i].Experation == closestExperation && Options[i].Strike == closestStrike)
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    index = 0;
                return Options[index];
            }

            public OptionChainDataPoint FindOption(string code)
            {
                int index = -1;

                for (int i = 0; i < Options.Count; i++)
                {
                    if (Options[i].Code == code)
                    {
                        index = i;
                        break;
                    }
                }
                if (index < 0)
                    index = 0;
                return Options[index];
            }

            public OptionChain SubChain(OptionType type)
            {
                List<OptionChainDataPoint> result = new List<OptionChainDataPoint>();
                for (int i = 0; i < Options.Count; i++)
                {
                    if (Options[i].Type == type)
                    {
                        result.Add(Options[i]);
                    }
                }
                return new OptionChain(Stock,DataDate,result);
            }

            public OptionChain SubChain(DateTime experation)
            {
                DateTime closestExperation = FindClosestExperation(experation);
                List<OptionChainDataPoint> result = new List<OptionChainDataPoint>();
                for (int i = 0; i < Options.Count; i++)
                {
                    if (Options[i].Experation == closestExperation)
                    {
                        result.Add(Options[i]);
                    }
                }
                return new OptionChain(Stock, DataDate, result);
            }

            public OptionChain SubChain(double strike)
            {
                List<OptionChainDataPoint> result = new List<OptionChainDataPoint>();
                for (int i = 0; i < Options.Count; i++)
                {
                    if (Options[i].Strike == strike)
                    {
                        result.Add(Options[i]);
                    }
                }
                return new OptionChain(Stock, DataDate, result);
            }

            public double StockPrice
            {
                get
                {
                    if (Options.Count > 0)
                        return Options[0].StockPrice;
                    else
                        return 0;
                }
            }
        }

        public class OptionChainDataPoint
        {
            public Stock Stock;
            public double StockPrice;
            public string Code;
            public OptionType Type;
            public DateTime Experation;
            public DateTime DataDate;
            public double Strike;
            public double Last;
            public double Bid;
            public double Ask;
            public double Volume;
            public double OpenInterest;

            public OptionChainDataPoint() { }
            public OptionChainDataPoint(Stock stock,double stockPrice, string code, OptionType type, DateTime dataDate, DateTime experationDate, double strike, double last, double bid, double ask, double volume, double openInterest)
            {
                Stock = stock;
                StockPrice = stockPrice;
                Code = code;
                Type = type;
                DataDate = dataDate;
                Experation = experationDate;
                Strike = strike;
                Last = last;
                Bid = bid;
                Ask = ask;
                Volume = volume;
                OpenInterest = openInterest;
            }
        }
    }
}
