using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Logging;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud
{
    public class RequesterWithRequestBase<TRequest, TResponse, TResponseData>
        : RequesterBase<TResponse, TResponseData>
        where TResponse : ResponseBase<TResponseData>, new()
    {
        internal RequesterWithRequestBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
        }

        public virtual async Task<TResponse> GetAsync(TRequest request = default)
        {
            using var scope = Logger.BeginRequestScope();
            ValidateRequest(request);

            return await DoSend(BuildResource(request), AddParameters(request));
        }

        protected virtual void ValidateRequest(TRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
        }

        protected virtual string BuildResource(TRequest request)
        {
            return string.Empty;
        }

        protected virtual async Task<TResponse> DoSend(string extraPath = default, Dictionary<string, string> parameters = null)
        {
            return GetStandardResponse(await Submitter.SubmitAsync($"{Url}{extraPath}", parameters ?? Parameters));
        }

        protected virtual Dictionary<string, string> AddParameters(TRequest request)
        {
            return new Dictionary<string, string>(Parameters);
        }
    }
}
