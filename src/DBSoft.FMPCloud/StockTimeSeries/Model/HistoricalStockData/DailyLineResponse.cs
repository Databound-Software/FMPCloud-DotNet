using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class DailyLineResponse : DailyResponseBase<DailyHeaderBase<DailyLineDetail>>
    {
    }

    public class DailyLineDetail
    {
        public DateTime Date { get; set; }
        public decimal Close { get; set; }
    }
}
