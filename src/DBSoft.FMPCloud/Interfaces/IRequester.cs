using System.Threading.Tasks;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IRequester<TRequest, TResponse>
    {
        Task<TResponse> GetAsync(TRequest request = default);
    }

    public interface IRequester<TResponse>
    {
        Task<TResponse> GetAsync();
    }
}
