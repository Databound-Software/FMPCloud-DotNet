namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IHistoricalStockData
    {
        IHistoricalChart HistoricalChart { get; set; }
        IDailyLine DailyLine { get; set; }
        IDailyChangeAndVolume DailyChangeAndVolume { get; set; }
        IDailyLastXDays DailyLastXDays { get; set; }
        IStockDividend DailyStockDividend { get; set; }
        IStockSplit DailyStockSplit { get; set; }
    }
}
