using System.Collections.Generic;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface ITickerSearch : IRequester<TickerSearchRequest, List<Model.TickerSearch>>
    {
    }
}
