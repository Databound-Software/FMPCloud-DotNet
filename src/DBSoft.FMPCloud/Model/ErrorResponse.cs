using Newtonsoft.Json;

namespace DBSoft.FMPCloud.Model
{
    public class ErrorResponse
    {
        [JsonProperty("Error Message")]
        public string ErrorMessage { get; set; }
    }
}
