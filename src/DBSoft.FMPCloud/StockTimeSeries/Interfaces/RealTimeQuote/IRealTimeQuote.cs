using System.Threading.Tasks;
using DBSoft.FMPCloud.Interfaces;
using DBSoft.FMPCloud.StockTimeSeries.Model;

namespace DBSoft.FMPCloud.StockTimeSeries
{
    public interface IRealTimeQuote : IRequester<RealTimeQuoteRequest, RealTimeQuoteResponse>
    {
        
    }
}
