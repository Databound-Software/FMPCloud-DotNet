namespace DBSoft.FMPCloud.Model
{
    public class ResponseBase<TResponseData>
    {
        public Status Status { get; set; }
        public string ErrorMessage { get; set; }
        public TResponseData Data { get; set; }
    }
}
