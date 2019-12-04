using System;
using Newtonsoft.Json;

namespace ZdAdoConnectorMvc.Models
{
    public class AdoProjectsResponse
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("value")]
        public Value[] Value { get; set; }
    }

    public class Value
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("revision")]
        public long Revision { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("lastUpdateTime")]
        public DateTimeOffset LastUpdateTime { get; set; }
    }

    public static class Converter
    {
        public static AdoProjectsResponse FromJson(string json) => JsonConvert.DeserializeObject<AdoProjectsResponse>(json);

        public static string ToJson(this AdoProjectsResponse self) => JsonConvert.SerializeObject(self);
    }
}
