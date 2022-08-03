using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class IndexConstituentsFacade : FacadeBase, IIndexConstituents
    {
        public IConstituents SP500 { get; internal set; }
        public IHistoricalConstituents SP500Historical { get; internal set; }
        public IConstituents Nasdaq100 { get; internal set; }
        public IHistoricalConstituents Nasdaq100Historical { get; internal set; }
        public IConstituents DowJones { get; internal set; }
        public IHistoricalConstituents DowJonesHistorical { get; internal set; }

        public IndexConstituentsFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            SP500 = new SP500(configuration, submitter, logger);
            SP500Historical = new SP500Historical(configuration, submitter, logger);
            Nasdaq100 = new Nasdaq100(configuration, submitter, logger);
            Nasdaq100Historical = new Nasdaq100Historical(configuration, submitter, logger);
            DowJones = new DowJones(configuration, submitter, logger);
            DowJonesHistorical = new DowJonesHistorical(configuration, submitter, logger);
        }
    }
}
