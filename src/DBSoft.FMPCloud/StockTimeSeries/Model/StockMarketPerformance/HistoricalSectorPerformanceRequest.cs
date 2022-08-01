namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class HistoricalSectorPerformanceRequest
    {
        /// <summary>
        /// The number of historical days to return. Defaults to 5
        /// </summary>
        public int Limit { get; set; }

        public HistoricalSectorPerformanceRequest()
        {
            Limit = 5;
        }
    }
}
