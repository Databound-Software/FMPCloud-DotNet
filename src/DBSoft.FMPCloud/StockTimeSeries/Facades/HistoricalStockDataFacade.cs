using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Requesters;
using Microsoft.Extensions.Logging;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public class HistoricalStockDataFacade : FacadeBase, IHistoricalStockData
    {
        public IHistoricalChart HistoricalChart { get; internal set; }
        public IDailyLine DailyLine { get; internal set; }
        public IDailyChangeAndVolume DailyChangeAndVolume { get; internal set; }
        public IDailyLastXDays DailyLastXDays { get; internal set; }
        public IStockDividend DailyStockDividend { get; internal set; }
        public IStockSplit DailyStockSplit { get; internal set; }

        public HistoricalStockDataFacade(IFmpCloudConfiguration configuration, ISubmitter submitter, ILogger<FmpCloudClient> logger)
            : base(configuration, submitter, logger)
        {
            HistoricalChart = new HistoricalChart(configuration, submitter, logger);
                  DailyLine = new DailyLine(configuration, submitter, logger);
                  DailyChangeAndVolume = new DailyChangeAndVolume(configuration, submitter, logger);
                  DailyLastXDays = new DailyLastXDays(configuration, submitter, logger);
                  DailyStockDividend = new StockDividend(configuration, submitter, logger);
                  DailyStockSplit = new StockSplit(configuration, submitter, logger);
        }
    }
}
