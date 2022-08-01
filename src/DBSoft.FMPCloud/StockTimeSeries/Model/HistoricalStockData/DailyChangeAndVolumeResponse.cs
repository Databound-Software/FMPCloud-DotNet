using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class DailyChangeAndVolumeResponse : DailyResponseBase<DailyHeaderBase<DailyChangeAndVolumeDetail>>
    {
    }

    public class DailyChangeAndVolumeDetail
    {
        public DateTime Date { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal AdjClose { get; set; }
        public double Volume { get; set; }
        public double UnadjustedVolume { get; set; }
        public double Change { get; set; }
        public double ChangePercent { get; set; }
        public double Vwap { get; set; }
        public string Label { get; set; }
        public double ChangeOverTime { get; set; }
    }
}
