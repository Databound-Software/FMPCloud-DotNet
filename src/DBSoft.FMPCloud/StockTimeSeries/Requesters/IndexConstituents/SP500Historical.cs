
using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class SP500Historical : RequesterWithoutRequestBase<HistoricalIndexConstituentsResponse, List<HistoricalIndexConstituent>>, IHistoricalConstituents
    {
        public SP500Historical(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger) :
            base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.SP500HistoricalPath;
        }
    }
}
