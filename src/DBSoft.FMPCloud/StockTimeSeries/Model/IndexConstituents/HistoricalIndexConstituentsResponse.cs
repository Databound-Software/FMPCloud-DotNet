using DBSoft.FMPCloud.Model;
using System;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class HistoricalIndexConstituentsResponse : ResponseBase<List<HistoricalIndexConstituent>>
    {
    }

    public class HistoricalIndexConstituent
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public string Reason { get; set; }
        public DateTime? DateAdded { get; set; }
        public string AddedSecurity { get; set; }
        public string RemovedTicker { get; set; }
        public string RemovedSecurity { get; set; }
    }
}
