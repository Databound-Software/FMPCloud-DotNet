using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class StockTimeSeriesProxy : ProxyBase, IStockTimeSeries
    {
        public IRealTimeQuote RealTimeQuote { get; set; }
        public ITickerSearch TickerSearch { get; set; }
        public ICompanyProfile CompanyProfile { get; set; }
        public IKeyExecutives KeyExecutives { get; set; }
        public IHistoricalStockData HistoricalStockData { get; set; }
        public IAvailableMarketAndTickers AvailableMarketsAndTickers { get; set; }
        public IIndexConstituents IndexConstituents { get; set; }
        public ITickerLists TickerLists { get; set; }
        public IStockMarketPerformances StockMarketPerformances { get; set; }


        public StockTimeSeriesProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new RealTimeQuote(configuration, submitter, logger),
                  new TickerSearch(configuration, submitter, logger),
                  new CompanyProfile(configuration, submitter, logger),
                  new KeyExecutives(configuration, submitter, logger),
                  new HistoricalStockDataProxy(configuration, submitter, logger),
                  new IndexConstituentsProxy(configuration, submitter, logger),
                  new TickerListsProxy(configuration, submitter, logger),
                  new StockMarketPerformancesProxy(configuration, submitter, logger))
        {

        }

        public StockTimeSeriesProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger, IRealTimeQuote realTimeQuote, ITickerSearch tickerSearch, ICompanyProfile companyProfile, IKeyExecutives keyExecutives, IHistoricalStockData historicalStockData, IIndexConstituents indexConstituents, ITickerLists tickerLists, IStockMarketPerformances stockMarketPerformances)
            : base(configuration, submitter, logger)
        {
            RealTimeQuote = realTimeQuote;
            TickerSearch = tickerSearch;
            CompanyProfile = companyProfile;
            KeyExecutives = keyExecutives;
            HistoricalStockData = historicalStockData;
            IndexConstituents = indexConstituents;
            TickerLists = tickerLists;
            StockMarketPerformances = stockMarketPerformances;
        }

    }
}
