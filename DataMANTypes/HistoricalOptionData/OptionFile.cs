using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;
using DataMAN;
using DataMAN.Options;

//Data Values
//0 = Symbol
//1 = underlaying price
//2 = OptionCode
//3 = type
//4 = experation
//5 = data date
//6 = strike
//7 = last
//8 = bid
//9 = ask
//10 = volume
//11 = open interest

namespace FinancialData
{
    namespace HistoricalOptionData
    {
        public class OptionFile
        {
            public string FilePath;

            public OptionFile(string file)
            {
                FilePath = file;
            }

            public OptionChain Load()
            {
                if (File.Exists(FilePath))
                {
                    string[] fileLines = File.ReadAllLines(FilePath);
                    if (fileLines.Length > 0)
                    {
                        string[] values = fileLines[0].Split(',');
                        Stock stock = new Stock(values[0]);
                        DateTime dataDate = DateTime.Parse(values[5]);
                        OptionChain result = new OptionChain(stock, dataDate);

                        for (int i = 0; i < fileLines.Length; i++)
                        {
                            values = fileLines[i].Split(',');
                            OptionChainDataPoint dataPoint = new OptionChainDataPoint()
                            {
                                Stock = stock,
                                StockPrice = Convert.ToDouble(values[1]),
                                Code = values[2],
                                Type = Option.ParseType(values[3]),
                                Experation = DateTime.Parse(values[4]),
                                DataDate = dataDate,
                                Strike = Convert.ToDouble(values[6]),
                                Last = Convert.ToDouble(values[7]),
                                Bid = Convert.ToDouble(values[8]),
                                Ask = Convert.ToDouble(values[9]),
                                Volume = Convert.ToDouble(values[10]),
                                OpenInterest = Convert.ToDouble(values[11])
                            };
                            result.Options.Add(dataPoint);
                        }
                        return result;
                    }
                }
                return null;
            }
        }
    }
}
