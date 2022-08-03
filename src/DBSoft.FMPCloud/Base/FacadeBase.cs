using DBSoft.FMPCloud.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud
{
    public class FacadeBase : FmpBase
    {
        internal FacadeBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }
    }
}
