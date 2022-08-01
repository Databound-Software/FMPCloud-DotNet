using DBSoft.FMPCloud.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class TradableSymbolList : TickerListBase, ITradableSymbolList
    {
        public TradableSymbolList(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.TradableListPath;
        }

    }
}
