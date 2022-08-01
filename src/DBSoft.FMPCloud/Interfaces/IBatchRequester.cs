using System.Threading.Tasks;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IBatchRequester<TBatchRequest, TResponse>
    {
        Task<TResponse> GetAsync(TBatchRequest request);
    }
}
