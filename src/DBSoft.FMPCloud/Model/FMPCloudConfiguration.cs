using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DBSoft.FMPCloud.Interfaces;

namespace DBSoft.FMPCloud.Model
{
    public class FMPCloudConfiguration : IFmpCloudConfiguration
    {
        public string ApiKey { get; set; }
        public JsonSerializerSettings SerializerSettings { get; set; }

        public FMPCloudConfiguration()
        {
            SerializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy()
                }
            };
        }
    }
}
