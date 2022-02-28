using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditSuisseInterview
{
    public enum TradeType
    {
        Credit,
        Equity,
        Derivatives
    }
    public class Trade
    {
        public string TreadId { get; set; }
        public TradeType TradeType { get; set; }
        public DateTime TradeDate { get; set; }
        public double TradeValue { get; set; }

    }
}
