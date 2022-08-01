using System.Collections.Generic;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class AvailableSecuritiesResponse : ResponseBase<List<AvailableSecurity>>
    {
    }

    public class AvailableSecurity
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string StockExchange { get; set; }
        public string ExchangeShortName { get; set; }
    }
}
