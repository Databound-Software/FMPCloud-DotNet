using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class DailyBase<TRequest, TResponseData> : SingleRequesterWithRequestBase<TRequest, TResponseData>
        where TRequest : PeriodOfTimeRequestBase
    {
        public DailyBase(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {

        }

        protected override Dictionary<string, string> AddParameters(TRequest request)

        {
            var parms = base.AddParameters(request);

            if (request.From.HasValue)
                parms.Add("from", $"{request.From:yyyy-MM-dd}");

            if (request.To.HasValue)
                parms.Add("to", $"{request.To:yyyy-MM-dd}");

            return parms;
        }
    }
}
