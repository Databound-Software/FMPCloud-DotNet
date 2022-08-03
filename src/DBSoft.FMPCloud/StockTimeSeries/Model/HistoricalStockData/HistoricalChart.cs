using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class HistoricalChart
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal Low { get; set; }
        public decimal High { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
    }
}
