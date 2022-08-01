namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface ITickerLists
    {
        IEtfList EtfList { get; set; }
        IStockList StockList { get; set; }
        ITradableSymbolList TradableSymbolList { get; set; }
    }
}
