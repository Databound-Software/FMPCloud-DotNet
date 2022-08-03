namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface ITickerLists
    {
        IEtfList EtfList { get;}
        IStockList StockList { get; }
        ITradableSymbolList TradableSymbolList { get; }
    }
}
