namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IAvailableMarketAndTickers
    {
        IAvailableSecurities AvailableAmex { get; set; }
        IAvailableSecurities AvailableCommodities { get; set; }
        IAvailableSecurities AvailableEtfs { get; set; }
        IAvailableSecurities AvailableEuronext { get; set; }
        IAvailableSecurities AvailableIndexes { get; set; }
        IAvailableSecurities AvailableMutualFunds { get; set; }
        IAvailableSecurities AvailableNasdaq { get; set; }
        IAvailableSecurities AvailableNyse { get; set; }
        IAvailableSecurities AvailableTsx { get; set; }
    }
}
