namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IStockTimeSeries
    {
        IRealTimeQuote RealTimeQuote { get; }
        ITickerSearch TickerSearch { get; }
        ICompanyProfile CompanyProfile { get; }
        IKeyExecutives KeyExecutives { get; }
        IHistoricalStockData HistoricalStockData { get; }
        IIndexConstituents IndexConstituents { get; }
        IStockMarketPerformances StockMarketPerformances { get; }
    }
}
