namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IHistoricalStockData
    {
        IHistoricalChart HistoricalChart { get; }
        IDailyLine DailyLine { get; }
        IDailyChangeAndVolume DailyChangeAndVolume { get; }
        IDailyLastXDays DailyLastXDays { get; }
        IStockDividend DailyStockDividend { get; }
        IStockSplit DailyStockSplit { get; }
    }
}
