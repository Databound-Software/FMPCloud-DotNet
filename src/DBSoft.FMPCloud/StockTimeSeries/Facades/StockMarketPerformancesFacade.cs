using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class StockMarketPerformancesFacade : FacadeBase, IStockMarketPerformances
    {
        public ITopActive TopActives { get; internal set; }
        public ITopLosers TopLosers { get; internal set; }
        public ITopGainers TopGainers { get; internal set; }
        public ISectorPerformance SectorPerformances { get; internal set; }
        public IHistoricalSectorPerformance HistoricalSectorPerformances { get; internal set; }
        public ITradingHours TradingHours { get; internal set; }

        public StockMarketPerformancesFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            TopActives = new TopActives(configuration, submitter, logger);
            TopLosers = new TopLosers(configuration, submitter, logger);
            TopGainers = new TopGainers(configuration, submitter, logger);
            SectorPerformances = new SectorPerformance(configuration, submitter, logger);
            HistoricalSectorPerformances = new HistoricalSectorPerformance(configuration, submitter, logger);
            TradingHours = new TradingHours(configuration, submitter, logger);
        }
    }
}
