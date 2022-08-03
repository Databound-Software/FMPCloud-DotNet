using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TickerSearch
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string StockExchange { get; set; }
        public Exchange ExchangeShortName { get; set; }
    }
}
