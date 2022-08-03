namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IIndexConstituents
    {
        IConstituents SP500 { get; }
        IHistoricalConstituents SP500Historical { get; }
        IConstituents Nasdaq100 { get; }
        IHistoricalConstituents Nasdaq100Historical { get; }
        IConstituents DowJones { get; }
        IHistoricalConstituents DowJonesHistorical { get; }
    }
}
