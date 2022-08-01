
using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.Model;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class TickerSearch : SingleRequesterWithRequestBase<TickerSearchRequest, TickerSearchResponse, List<Model.TickerSearch>>, ITickerSearch
    {
        public TickerSearch(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.TickerSearchPath;
        }

        protected override Dictionary<string, string> AddParameters(TickerSearchRequest request)
        {
            var parms = Parameters;

            parms.Add("query", request.Symbol);
            parms.Add("limit", request.Limit.ToString());
            if (request.Exchange != Exchange.All)
                parms.Add("exchange", request.Exchange.ToString());

            return parms;
        }
    }
}
