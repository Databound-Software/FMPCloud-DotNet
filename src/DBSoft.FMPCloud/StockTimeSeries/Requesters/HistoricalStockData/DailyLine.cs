using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class DailyLine : SingleRequesterWithRequestBase<DailyLineRequest, DailyHeaderBase<DailyLineDetail>>, IDailyLine
    {
        public DailyLine(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.HistoricalPricePath;
        }

        protected override Dictionary<string, string> AddParameters(DailyLineRequest request)
        {
            var parms = base.AddParameters(request);
            parms.Add("serietype", "line");

            return parms;
        }
    }
}
