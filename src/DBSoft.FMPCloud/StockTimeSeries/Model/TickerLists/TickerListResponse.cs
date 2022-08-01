using DBSoft.FMPCloud.Model;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TickerListResponse : ResponseBase<List<TickerListDetail>>
    {
    }

    public class TickerListDetail
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Exchange { get; set; }
        public string ExchangeShortName { get; set; }
        public string Type { get; set; }
    }
}
