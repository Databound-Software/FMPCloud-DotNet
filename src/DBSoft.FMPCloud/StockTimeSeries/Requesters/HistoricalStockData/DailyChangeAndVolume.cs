using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class DailyChangeAndVolume : SingleRequesterWithRequestBase<DailyChangeAndVolumeRequest, DailyHeaderBase<DailyChangeAndVolumeDetail>>, IDailyChangeAndVolume
    {
        public DailyChangeAndVolume(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.HistoricalPricePath;
        }

        protected override Dictionary<string, string> AddParameters(DailyChangeAndVolumeRequest request)
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
