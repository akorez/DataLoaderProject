using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseInterview.Concrete
{
    public class CSVDataLoader : IDataLoad
    {
        public List<Trade> LoadData(string filePath)
        {
            List<Trade> result = new List<Trade>();

            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');


                    result.Add(new Trade
                    {
                        TreadId = values[0].ToString(),
                        TradeType = (TradeType)Enum.Parse(typeof(TradeType), values[1]),
                        TradeDate = Convert.ToDateTime(values[2]),
                        TradeValue = double.Parse(values[3], System.Globalization.CultureInfo.InvariantCulture)
                    });
                }

            }

            return result;
        }
    }
}
