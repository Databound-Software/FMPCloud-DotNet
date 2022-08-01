using System;
using Newtonsoft.Json;

namespace DBSoft.FMPCloud.Utilities.JsonConverters
{
    public class PercentageJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
            => objectType.Name.Equals(nameof(String));

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
            => decimal.Parse(((string)reader.Value).Replace("%", string.Empty));


        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue($"{value}%");
    }
}
