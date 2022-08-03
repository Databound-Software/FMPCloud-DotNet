using DBSoft.FMPCloud.Utilities.JsonConverters;
using Newtonsoft.Json;

namespace DBSoft.FMPCloud.StockTimeSeries.Model
{
    public class SectorPerformanceDetail
    {
        public string Sector { get; set; }
        [JsonConverter(typeof(PercentageJsonConverter))]
        public decimal ChangesPercentage { get; set; }
    }
}
