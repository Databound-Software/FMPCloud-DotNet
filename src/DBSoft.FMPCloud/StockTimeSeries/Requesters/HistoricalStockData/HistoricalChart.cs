using System;
using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries.Requesters
{
    public class HistoricalChart : SingleRequesterWithRequestBase<HistoricalChartRequest, List<Model.HistoricalChart>>, IHistoricalChart
    {
        public HistoricalChart(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            RequesterPath = StaticResources.HistoricalChartPath;
        }

        protected override string BuildResource(HistoricalChartRequest request)
        {
            var interval = FormatIntervalForPath(request.Interval);
            return $"{interval}/{request.Symbol}";
        }

        protected virtual string FormatIntervalForPath(ChartInterval interval)
        {
            return interval switch
            {
                ChartInterval.OneMinute => "1min",
                ChartInterval.FiveMinutes => "5min",
                ChartInterval.FifteenMinutes => "15min",
                ChartInterval.ThirtyMinutes => "30min",
                ChartInterval.OneHour => "1hour",
                _ => throw new ArgumentOutOfRangeException(nameof(interval)),
            };
        }
    }
}
