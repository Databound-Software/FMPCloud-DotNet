using DBSoft.FMPCloud.Model;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IResponse<TResponseData>
    {
        Status Status { get; set; }
        string ErrorMessage { get; set; }
        TResponseData Data { get; set; }
    }
}
