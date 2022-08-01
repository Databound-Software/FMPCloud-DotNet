using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class AvailableMarketAndTickersProxy : ProxyBase, IAvailableMarketAndTickers
    {
        public IAvailableSecurities AvailableAmex { get; set; }
        public IAvailableSecurities AvailableCommodities { get; set; }
        public IAvailableSecurities AvailableEtfs { get; set; }
        public IAvailableSecurities AvailableEuronext { get; set; }
        public IAvailableSecurities AvailableIndexes { get; set; }
        public IAvailableSecurities AvailableMutualFunds { get; set; }
        public IAvailableSecurities AvailableNasdaq { get; set; }
        public IAvailableSecurities AvailableNyse { get; set; }
        public IAvailableSecurities AvailableTsx { get; set; }

        public AvailableMarketAndTickersProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new AvailableAmex(configuration, submitter, logger),
                  new AvailableCommodities(configuration, submitter, logger),
                  new AvailableEtfs(configuration, submitter, logger),
                  new AvailableEuronext(configuration, submitter, logger),
                  new AvailableIndexes(configuration, submitter, logger),
                  new AvailableMutualFunds(configuration, submitter, logger),
                  new AvailableNasdaq(configuration, submitter, logger),
                  new AvailableNyse(configuration, submitter, logger),
                  new AvailableTsx(configuration, submitter, logger))
        {

        }

        public AvailableMarketAndTickersProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger, IAvailableSecurities availableAmex, IAvailableSecurities availableCommodities, IAvailableSecurities availableEtfs, IAvailableSecurities availableEuronext, IAvailableSecurities availableIndexes, IAvailableSecurities availableMutualFunds, IAvailableSecurities availableNasdaq, IAvailableSecurities availableNyse, IAvailableSecurities availableTsx)
            : base(configuration, submitter, logger)
        {
            AvailableAmex = availableAmex;
            AvailableCommodities = availableCommodities;
            AvailableEtfs = availableEtfs;
            AvailableEuronext = availableEuronext;
            AvailableIndexes = availableIndexes;
            AvailableMutualFunds = availableMutualFunds;
            AvailableNasdaq = availableNasdaq;
            AvailableNyse = availableNyse;
            AvailableTsx = availableTsx;
        }
    }
}
