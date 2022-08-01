using DBSoft.FMPCloud.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class TopGainers : TopListBase, ITopGainers
    {
        public TopGainers(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.TopGainersPath;
        }
    }
}
