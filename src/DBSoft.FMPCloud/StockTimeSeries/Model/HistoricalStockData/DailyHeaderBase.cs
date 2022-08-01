using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class DailyHeaderBase<T>
    {
        public string Symbol { get; set; }
        public IList<T> Historical { get; set; }
    }
}
