using DBSoft.FMPCloud.Model;
using System;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class IndexConstituentsResponse : ResponseBase<List<IndexConstituent>>
    {
    }

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
