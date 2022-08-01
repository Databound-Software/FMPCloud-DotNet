using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IStockList : IRequester<TickerListResponse>
    {
    }
}
