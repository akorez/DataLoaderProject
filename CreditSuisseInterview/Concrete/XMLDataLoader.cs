using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CreditSuisseInterview.Concrete
{
    public class XMLDataLoader : IDataLoad
    {
        public List<Trade> LoadData(string filePath)
        {
            List<Trade> result = new List<Trade>();

            using var readerXml = XmlReader.Create(filePath);

            readerXml.ReadToFollowing("record");

            do
            {
                Trade trade = new Trade();

                readerXml.ReadToFollowing("tradeId");
                trade.TreadId = readerXml.ReadElementContentAsString();

                readerXml.ReadToFollowing("tradeType");
                trade.TradeType = (TradeType)Enum.Parse(typeof(TradeType), readerXml.ReadElementContentAsString());

                readerXml.ReadToFollowing("tradeDate");
                trade.TradeDate = Convert.ToDateTime(readerXml.ReadElementContentAsString());

                readerXml.ReadToFollowing("tradeValue");
                trade.TradeValue = double.Parse(readerXml.ReadElementContentAsString(), System.Globalization.CultureInfo.InvariantCulture);

                result.Add(trade);


            } while (readerXml.ReadToFollowing("record"));

            return result;
        }
    }
}
