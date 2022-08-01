using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class DailyLastXDaysRequest : StandardRequestBase
    {
        /// <summary>
        /// The number of days to look back, for example "The last 5 days". Default value is 7
        /// </summary>
        public int NumberOfDays { get; set; }

        public DailyLastXDaysRequest()
        {
            NumberOfDays = 7;
        }
    }
}
