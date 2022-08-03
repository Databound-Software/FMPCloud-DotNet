namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IAvailableMarketAndTickers
    {
        IAvailableSecurities AvailableAmex { get; }
        IAvailableSecurities AvailableCommodities { get; }
        IAvailableSecurities AvailableEtfs { get; }
        IAvailableSecurities AvailableEuronext { get; }
        IAvailableSecurities AvailableIndexes { get; }
        IAvailableSecurities AvailableMutualFunds { get; }
        IAvailableSecurities AvailableNasdaq { get; }
        IAvailableSecurities AvailableNyse { get; }
        IAvailableSecurities AvailableTsx { get; }
    }
}
