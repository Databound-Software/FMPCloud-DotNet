using DBSoft.FMPCloud.Interfaces;

namespace DBSoft.FMPCloud.Model
{
    public class StandardBatchRequestBase : IBatchRequest
    {
        public string[] Symbols { get; set; }
    }
}
