namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IStockMarketPerformances
    {
        ITopActive TopActives { get; set; }
        ITopLosers TopLosers { get; set; }
        ITopGainers TopGainers { get; set; }
        ISectorPerformance SectorPerformances { get; set; }
        IHistoricalSectorPerformance HistoricalSectorPerformances { get; set; }
        ITradingHours TradingHours { get; set; }
    }
}
