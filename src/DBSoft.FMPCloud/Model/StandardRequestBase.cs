using DBSoft.FMPCloud.Interfaces;

namespace DBSoft.FMPCloud.Model
{
    public class StandardRequestBase : IRequest
    {
        public string Symbol { get; set; }
    }
}
