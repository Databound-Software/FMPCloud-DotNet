using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DBSoft.FMPCloud.Interfaces;

namespace DBSoft.FMPCloud.Model
{
    public class FmpCloudConfiguration : IFmpCloudConfiguration
    {
        public string ApiKey { get; set; }
        public JsonSerializerSettings SerializerSettings { get; set; }

        public FmpCloudConfiguration()
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
