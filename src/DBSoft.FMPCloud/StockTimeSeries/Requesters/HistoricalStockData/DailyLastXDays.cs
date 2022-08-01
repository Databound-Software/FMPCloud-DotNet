
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;


namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class DailyLastXDays : SingleRequesterWithRequestBase<DailyLastXDaysRequest, DailyChangeAndVolumeResponse, DailyHeaderBase<DailyChangeAndVolumeDetail>>, IDailyLastXDays
    {
        public DailyLastXDays(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.HistoricalPricePath;
        }

        protected override Dictionary<string, string> AddParameters(DailyLastXDaysRequest request)
        {
            var parms = base.AddParameters(request);

            parms.Add("timeseries", request.NumberOfDays.ToString());

            return parms;
        }
    }
}
