using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class StockTimeSeriesFacade : FacadeBase, IStockTimeSeries
    {
        public IRealTimeQuote RealTimeQuote { get; internal set; }
        public ITickerSearch TickerSearch { get; internal set; }
        public ICompanyProfile CompanyProfile { get; internal set; }
        public IKeyExecutives KeyExecutives { get; internal set; }
        public IHistoricalStockData HistoricalStockData { get; internal set; }
        public IAvailableMarketAndTickers AvailableMarketsAndTickers { get; internal set; }
        public IIndexConstituents IndexConstituents { get; internal set; }
        public ITickerLists TickerLists { get; internal set; }
        public IStockMarketPerformances StockMarketPerformances { get; internal set; }


        public StockTimeSeriesFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RealTimeQuote = new RealTimeQuote(configuration, submitter, logger);
            TickerSearch = new TickerSearch(configuration, submitter, logger);
            CompanyProfile = new CompanyProfile(configuration, submitter, logger);
            KeyExecutives = new KeyExecutives(configuration, submitter, logger);
            HistoricalStockData = new HistoricalStockDataFacade(configuration, submitter, logger);
            IndexConstituents = new IndexConstituentsFacade(configuration, submitter, logger);
            TickerLists = new TickerListsFacade(configuration, submitter, logger);
            StockMarketPerformances = new StockMarketPerformancesFacade(configuration, submitter, logger);
        }
    }
}
