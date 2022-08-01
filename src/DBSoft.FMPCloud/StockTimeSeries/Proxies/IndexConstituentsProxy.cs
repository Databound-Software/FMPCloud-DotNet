using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class IndexConstituentsProxy : ProxyBase, IIndexConstituents
    {
        public IConstituents SP500 { get; set; }
        public IHistoricalConstituents SP500Historical { get; set; }
        public IConstituents Nasdaq100 { get; set; }
        public IHistoricalConstituents Nasdaq100Historical { get; set; }
        public IConstituents DowJones { get; set; }
        public IHistoricalConstituents DowJonesHistorical { get; set; }

        public IndexConstituentsProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new SP500(configuration, submitter, logger),
                  new SP500Historical(configuration, submitter, logger),
                  new Nasdaq100(configuration, submitter, logger),
                  new Nasdaq100Historical(configuration, submitter, logger),
                  new DowJones(configuration, submitter, logger),
                  new DowJonesHistorical(configuration, submitter, logger))
        {

        }

        public IndexConstituentsProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger, IConstituents sp500, IHistoricalConstituents sp500Historical, IConstituents nasdaq100, IHistoricalConstituents nasdaq100Historical, IConstituents dowJones, IHistoricalConstituents dowJonesHistorical)
            : base(configuration, submitter, logger)
        {
            SP500 = sp500;
            SP500Historical = sp500Historical;
            Nasdaq100 = nasdaq100;
            Nasdaq100Historical = nasdaq100Historical;
            DowJones = dowJones;
            DowJonesHistorical = dowJonesHistorical;
        }

    }
}
