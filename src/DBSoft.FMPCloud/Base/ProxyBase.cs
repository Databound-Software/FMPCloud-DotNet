using DBSoft.FMPCloud.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud
{
    public class ProxyBase : FmpBase
    {
        internal ProxyBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }
    }
}
