using DBSoft.FMPCloud.Interfaces;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud
{
    public class FmpBase
    {
        protected readonly IFmpCloudConfiguration Configuration;
        protected readonly ISubmitter Submitter;
        protected readonly ILogger Logger;

        internal FmpBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
        {
            Configuration = configuration;
            Submitter = submitter;
            Logger = logger;
        }
    }
}
