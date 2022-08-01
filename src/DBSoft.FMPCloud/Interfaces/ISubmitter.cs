using System.Collections.Generic;
using System.Threading.Tasks;
using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface ISubmitter
    {
        Task<SubmitResponse> SubmitAsync(string destination, Dictionary<string, string> parameters);
    }
}
