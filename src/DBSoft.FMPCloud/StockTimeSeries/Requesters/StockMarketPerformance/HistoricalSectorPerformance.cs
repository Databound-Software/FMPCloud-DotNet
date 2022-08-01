
using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class HistoricalSectorPerformance : RequesterWithRequestBase<HistoricalSectorPerformanceRequest, HistoricalSectorPerformanceResponse, List<HistoricalSectorPerformanceDetail>>, IHistoricalSectorPerformance
    {
        public HistoricalSectorPerformance(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.HistoricalSectorPerformancePath;
        }

        protected override Dictionary<string, string> AddParameters(HistoricalSectorPerformanceRequest request)
        {
            var parms = base.AddParameters(request);
            parms.Add("limit", request.Limit.ToString());

            return parms;
        }

    }
}
