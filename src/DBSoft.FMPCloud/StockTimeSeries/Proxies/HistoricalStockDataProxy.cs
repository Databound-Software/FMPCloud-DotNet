using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class HistoricalStockDataProxy : ProxyBase, IHistoricalStockData
    {
        public IHistoricalChart HistoricalChart { get; set; }
        public IDailyLine DailyLine { get; set; }
        public IDailyChangeAndVolume DailyChangeAndVolume { get; set; }
        public IDailyLastXDays DailyLastXDays { get; set; }
        public IStockDividend DailyStockDividend { get; set; }
        public IStockSplit DailyStockSplit { get; set; }

        public HistoricalStockDataProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : this(configuration, submitter, logger,
                  new HistoricalChart(configuration, submitter, logger),
                  new DailyLine(configuration, submitter, logger),
                  new DailyChangeAndVolume(configuration, submitter, logger),
                  new DailyLastXDays(configuration, submitter, logger),
                  new StockDividend(configuration, submitter, logger),
                  new StockSplit(configuration, submitter, logger))
        {

        }

        public HistoricalStockDataProxy(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger, IHistoricalChart historicalChart, IDailyLine dailyLine, IDailyChangeAndVolume dailyChangeAndVolume, IDailyLastXDays dailyLastXDays, IStockDividend stockDividend, IStockSplit stockSplit)
            : base(configuration, submitter, logger)
        {
            HistoricalChart = historicalChart;
            DailyLine = dailyLine;
            DailyChangeAndVolume = dailyChangeAndVolume;
            DailyLastXDays = dailyLastXDays;
            DailyStockDividend = stockDividend;
            DailyStockSplit = stockSplit;
        }
    }
}
