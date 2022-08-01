using System.Net;

namespace DBSoft.FMPCloud.Model
{
    public class SubmitResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Content { get; set; }
    }
}
