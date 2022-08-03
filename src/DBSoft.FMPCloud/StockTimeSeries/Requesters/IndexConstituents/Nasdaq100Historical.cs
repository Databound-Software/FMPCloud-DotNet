using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class Nasdaq100Historical : RequesterWithoutRequestBase<List<HistoricalIndexConstituent>>, IHistoricalConstituents
    {
        public Nasdaq100Historical(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger) :
            base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.Nasdaq100HistoricalPath;
        }
    }
}
