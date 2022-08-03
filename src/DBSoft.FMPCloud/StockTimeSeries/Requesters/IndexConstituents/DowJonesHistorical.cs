using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class DowJonesHistorical : RequesterWithoutRequestBase<List<HistoricalIndexConstituent>>, IHistoricalConstituents
    {
        public DowJonesHistorical(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger) :
            base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.DownJonesHistoricalPath;
        }
    }
}
