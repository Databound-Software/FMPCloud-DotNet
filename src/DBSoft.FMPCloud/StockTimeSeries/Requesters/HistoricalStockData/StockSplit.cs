using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class StockSplit : DailyBase<StockSplitRequest, DailyHeaderBase<StockSplitDetail>>, IStockSplit
    {
        public StockSplit(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.StockSplitPath;
        }
    }
}
