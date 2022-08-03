using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;
using DBSoft.FMPCloud.Model;
using System.Collections.Generic;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IEtfList : IRequester<List<TickerListDetail>>
    {
    }
}
