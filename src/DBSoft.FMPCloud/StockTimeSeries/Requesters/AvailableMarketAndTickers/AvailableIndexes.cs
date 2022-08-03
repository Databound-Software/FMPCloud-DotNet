using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class AvailableIndexes : AvailableSecuritiesBase, IAvailableSecurities
    {
        public AvailableIndexes(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }

        public override Task<ResponseBase<List<AvailableSecurity>>> GetAsync(StandardRequestBase request = default)
        {
            return base.GetAsync(new StandardRequestBase { Symbol = "available-indexes" });
        }
    }
}
