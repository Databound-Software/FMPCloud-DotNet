using DBSoft.FMPCloud.Interfaces;

namespace DBSoft.FMPCloud.Model
{
    public class ResponseBase<TResponseData> : IResponse<TResponseData>
    {
        public Status Status { get; set; }
        public string ErrorMessage { get; set; }
        public TResponseData Data { get; set; }
    }
}
