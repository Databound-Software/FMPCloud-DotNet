using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Logging;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud
{
    public class RequesterWithoutRequestBase<TResponseData> : RequesterBase<TResponseData>
    {

        internal RequesterWithoutRequestBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }

        public virtual async Task<ResponseBase<TResponseData>> GetAsync()
        {
            using var scope = Logger.BeginRequestScope();
            return await DoSend();

        }

        protected virtual async Task<ResponseBase<TResponseData>> DoSend()
        {
            return GetStandardResponse(await Submitter.SubmitAsync(Url, Parameters));
        }
    }
}
