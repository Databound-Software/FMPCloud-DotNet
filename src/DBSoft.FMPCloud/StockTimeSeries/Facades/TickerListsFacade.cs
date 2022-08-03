using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class TickerListsFacade : FacadeBase, ITickerLists
    {
        public IEtfList EtfList { get; internal set; }
        public IStockList StockList { get; internal set; }
        public ITradableSymbolList TradableSymbolList { get; internal set; }
        public TickerListsFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base (configuration, submitter, logger)
        {
            EtfList = new EtfList(configuration, submitter, logger);
            StockList = new StockList(configuration, submitter, logger);
            TradableSymbolList = new TradableSymbolList(configuration, submitter, logger);
        }
    }
}
