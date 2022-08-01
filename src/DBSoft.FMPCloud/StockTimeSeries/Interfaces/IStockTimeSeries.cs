namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IStockTimeSeries
    {
        IRealTimeQuote RealTimeQuote { get; set; }
        ITickerSearch TickerSearch { get; set; }
        ICompanyProfile CompanyProfile { get; set; }
        IKeyExecutives KeyExecutives { get; set; }
        IHistoricalStockData HistoricalStockData { get; set; }
        IIndexConstituents IndexConstituents { get; set; }
        IStockMarketPerformances StockMarketPerformances { get; set; }
    }
}
