using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class TickerSearchRequest : StandardRequestBase
    {
        public int Limit { get; set; }
        public Exchange Exchange { get; set; }

        public TickerSearchRequest()
        {
            Limit = 10;
        }
    }
}
