using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class StockSplitResponse : DailyResponseBase<DailyHeaderBase<StockSplitDetail>>
    {
    }

    public class StockSplitDetail
    {
        public DateTime Date { get; set; }
        public string Label { get; set; }
        public double Numerator { get; set; }
        public double Denominator { get; set; }
    }
}
