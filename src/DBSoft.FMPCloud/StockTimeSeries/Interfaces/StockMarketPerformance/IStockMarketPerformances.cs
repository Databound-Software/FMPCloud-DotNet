namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IStockMarketPerformances
    {
        ITopActive TopActives { get; }
        ITopLosers TopLosers { get; }
        ITopGainers TopGainers { get; }
        ISectorPerformance SectorPerformances { get; }
        IHistoricalSectorPerformance HistoricalSectorPerformances { get; }
        ITradingHours TradingHours { get; }
    }
}
