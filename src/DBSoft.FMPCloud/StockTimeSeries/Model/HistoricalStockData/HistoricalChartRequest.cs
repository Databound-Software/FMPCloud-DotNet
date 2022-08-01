using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class HistoricalChartRequest : StandardRequestBase
    {
        public ChartInterval Interval { get; set; }
    }
}
