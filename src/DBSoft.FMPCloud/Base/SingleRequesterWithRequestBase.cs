using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using System;

namespace DBSoft.FMPCloud
{
    public class SingleRequesterWithRequestBase<TRequest, TResponse, TResponseData> : RequesterWithRequestBase<TRequest, TResponse, TResponseData>
        where TResponse : ResponseBase<TResponseData>, new()
        where TRequest : StandardRequestBase
    {
        internal SingleRequesterWithRequestBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {

        }

        protected override string BuildResource(TRequest request)
        {
            return request.Symbol;
        }

        protected override void ValidateRequest(TRequest request)
        {
            base.ValidateRequest(request);

            if (string.IsNullOrEmpty(request.Symbol))
                throw new InvalidOperationException("Symbol is required");
        }
    }
}
