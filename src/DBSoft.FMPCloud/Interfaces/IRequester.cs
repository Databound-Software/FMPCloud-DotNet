using DBSoft.FMPCloud.Model;
using System.Threading.Tasks;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IRequester<TRequest, TResponseData>
    {
        Task<ResponseBase<TResponseData>> GetAsync(TRequest request = default);
    }

    public interface IRequester<TResponseData>
    {
        Task<ResponseBase<TResponseData>> GetAsync();
    }
}
