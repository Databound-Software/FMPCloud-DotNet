using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class RealTimeQuote : BatchRequesterWithRequestBase<RealTimeQuoteRequest, List<Model.RealTimeQuote>>, IRealTimeQuote
    {
        public RealTimeQuote(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.RealTimeQuotePath;
        }
    }
}
