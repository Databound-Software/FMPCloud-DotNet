using System;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class IndexConstituent
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string SubSector { get; set; }
        public string HeadQuarter { get; set; }
        public DateTime? DateFirstAdded { get; set; }
        public string Cik { get; set; }
        public DateTime Founded { get; set; }
    }
}
