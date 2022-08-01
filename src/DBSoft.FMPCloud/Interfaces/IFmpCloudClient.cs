using DBSoft.FMPCloud.StockTimeSeries;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IFmpCloudClient
    {
        IStockTimeSeries StockTimeSeries { get; set; }
    }
}
