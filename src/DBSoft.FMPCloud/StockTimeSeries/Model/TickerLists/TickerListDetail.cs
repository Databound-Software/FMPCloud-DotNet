namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
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
