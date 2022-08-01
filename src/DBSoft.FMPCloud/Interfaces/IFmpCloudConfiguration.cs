using Newtonsoft.Json;

namespace DBSoft.FMPCloud.Interfaces
{
    public interface IFmpCloudConfiguration
    {
        string ApiKey { get; set; }
        JsonSerializerSettings SerializerSettings { get; set; }
    }
}