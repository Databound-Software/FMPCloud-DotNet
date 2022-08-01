using System;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class PeriodOfTimeRequestBase : StandardRequestBase
    {
        /// <summary>
        /// Optional parameter to retrieve daily data for a specific period of time
        /// If omitted, will include data from the beginning of time for the specified symbol
        /// </summary>
        public DateTime? From { get; set; }
        /// <summary>
        /// Optional parameter to retrieve daily data for a specific period of time
        /// If omitted, will include data to the most recent date for the specified symbol
        /// </summary>
        public DateTime? To { get; set; }
    }
}
