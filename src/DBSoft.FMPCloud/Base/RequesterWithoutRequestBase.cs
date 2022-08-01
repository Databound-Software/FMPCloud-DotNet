using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Logging;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud
{
    public class RequesterWithoutRequestBase<TResponse, TResponseData> : RequesterBase<TResponse, TResponseData>
        where TResponse : ResponseBase<TResponseData>, new()
    {

        internal RequesterWithoutRequestBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }

        public virtual async Task<TResponse> GetAsync()
        {
            using var scope = Logger.BeginRequestScope();
            return await DoSend();

        }

        protected virtual async Task<TResponse> DoSend()
        {
            return GetStandardResponse(await Submitter.SubmitAsync(Url, Parameters));
        }
    }
}
