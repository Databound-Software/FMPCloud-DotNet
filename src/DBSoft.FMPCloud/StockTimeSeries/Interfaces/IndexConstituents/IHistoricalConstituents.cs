using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IHistoricalConstituents : IRequester<List<HistoricalIndexConstituent>>
    {
    }
}
