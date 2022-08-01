using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class TickerListsProxy : ProxyBase, ITickerLists
    {
        public IEtfList EtfList { get; set; }
        public IStockList StockList { get; set; }
        public ITradableSymbolList TradableSymbolList { get; set; }
        public TickerListsProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new EtfList(configuration, submitter, logger),
                  new StockList(configuration, submitter, logger),
                  new TradableSymbolList(configuration, submitter, logger))
        {

        }

        public TickerListsProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger, IEtfList etfList, IStockList stockList, ITradableSymbolList tradableSymbolList)
            : base(configuration, submitter, logger)
        {
            EtfList = etfList;
            StockList = stockList;
            TradableSymbolList = tradableSymbolList;
        }
    }
}
