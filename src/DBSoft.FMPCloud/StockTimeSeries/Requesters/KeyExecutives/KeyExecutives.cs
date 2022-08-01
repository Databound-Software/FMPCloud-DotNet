
using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class KeyExecutives : BatchRequesterWithRequestBase<KeyExecutivesRequest, KeyExecutivesResponse, List<KeyExecutive>>, IKeyExecutives
    {
        public KeyExecutives(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.KeyExecutivesPath;
        }
    }
}
