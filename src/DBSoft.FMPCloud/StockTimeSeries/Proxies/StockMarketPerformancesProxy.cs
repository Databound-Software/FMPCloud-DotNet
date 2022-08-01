using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class StockMarketPerformancesProxy : ProxyBase, IStockMarketPerformances
    {
        public ITopActive TopActives { get; set; }
        public ITopLosers TopLosers { get; set; }
        public ITopGainers TopGainers { get; set; }
        public ISectorPerformance SectorPerformances { get; set; }
        public IHistoricalSectorPerformance HistoricalSectorPerformances { get; set; }
        public ITradingHours TradingHours { get; set; }

        public StockMarketPerformancesProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new TopActives(configuration, submitter, logger),
                  new TopLosers(configuration, submitter, logger),
                  new TopGainers(configuration, submitter, logger),
                  new SectorPerformance(configuration, submitter, logger),
                  new HistoricalSectorPerformance(configuration, submitter, logger),
                  new TradingHours(configuration, submitter, logger))
        {

        }

        public StockMarketPerformancesProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger,
            ITopActive topActives, ITopLosers topLosers, ITopGainers topGainers, ISectorPerformance sectorPerformances, IHistoricalSectorPerformance historicalSectorPerformances, ITradingHours tradingHours)
            : base(configuration, submitter, logger)
        {
            TopActives = topActives;
            TopLosers = topLosers;
            TopGainers = topGainers;
            SectorPerformances = sectorPerformances;
            HistoricalSectorPerformances = historicalSectorPerformances;
            TradingHours = tradingHours;
        }
    }
}
