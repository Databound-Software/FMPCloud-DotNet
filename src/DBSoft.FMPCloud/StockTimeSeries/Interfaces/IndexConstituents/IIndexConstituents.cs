namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IIndexConstituents
    {
        IConstituents SP500 { get; set; }
        IHistoricalConstituents SP500Historical { get; set; }
        IConstituents Nasdaq100 { get; set; }
        IHistoricalConstituents Nasdaq100Historical { get; set; }
        IConstituents DowJones { get; set; }
        IHistoricalConstituents DowJonesHistorical { get; set; }
    }
}
