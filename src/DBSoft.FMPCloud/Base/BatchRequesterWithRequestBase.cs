using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace DBSoft.FMPCloud
{
    public class BatchRequesterWithRequestBase<TRequest, TResponse, TResponseData> : RequesterWithRequestBase<TRequest, TResponse, TResponseData>
        where TResponse : ResponseBase<TResponseData>, new()
        where TRequest : StandardBatchRequestBase
    {
        internal BatchRequesterWithRequestBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {

        }

        protected override string BuildResource(TRequest request) 
            => string.Join(",", request.Symbols);

        protected override void ValidateRequest(TRequest request)
        {
            base.ValidateRequest(request);

            if (!request.Symbols.Any())
                throw new InvalidOperationException("At least one Symbol is required");
        }
    }
}
