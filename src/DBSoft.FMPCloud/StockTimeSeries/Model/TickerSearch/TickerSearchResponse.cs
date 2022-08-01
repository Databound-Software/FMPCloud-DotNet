using System.Collections.Generic;
using System.Runtime.Serialization;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TickerSearchResponse : ResponseBase<List<TickerSearch>>
    {
    }

    [DataContract]
    public class TickerSearch
    {
        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "currency")]
        public string Currency { get; set; }
        [DataMember(Name = "stockExchange")]
        public string StockExchange { get; set; }
        [DataMember(Name = "exchangeShortName")]
        public Exchange ExchangeShortName { get; set; }
    }
}
