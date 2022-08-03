using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class AvailableMarketAndTickersFacade : FacadeBase, IAvailableMarketAndTickers
    {
        public IAvailableSecurities AvailableAmex { get; internal set; }
        public IAvailableSecurities AvailableCommodities { get; internal set; }
        public IAvailableSecurities AvailableEtfs { get; internal set; }
        public IAvailableSecurities AvailableEuronext { get; internal set; }
        public IAvailableSecurities AvailableIndexes { get; internal set; }
        public IAvailableSecurities AvailableMutualFunds { get; internal set; }
        public IAvailableSecurities AvailableNasdaq { get; internal set; }
        public IAvailableSecurities AvailableNyse { get; internal set; }
        public IAvailableSecurities AvailableTsx { get; internal set; }

        public AvailableMarketAndTickersFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            AvailableAmex = new AvailableAmex(configuration, submitter, logger);
                  AvailableCommodities = new AvailableCommodities(configuration, submitter, logger);
                  AvailableEtfs = new AvailableEtfs(configuration, submitter, logger);
                  AvailableEuronext = new AvailableEuronext(configuration, submitter, logger);
                  AvailableIndexes = new AvailableIndexes(configuration, submitter, logger);
                  AvailableMutualFunds = new AvailableMutualFunds(configuration, submitter, logger);
                  AvailableNasdaq = new AvailableNasdaq(configuration, submitter, logger);
                  AvailableNyse = new AvailableNyse(configuration, submitter, logger);
                  AvailableTsx = new AvailableTsx(configuration, submitter, logger);
        }
    }
}
