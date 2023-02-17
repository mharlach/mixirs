using Newtonsoft.Json;

namespace Mixirs.Models
{
    public class ItemPair
    {

        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;
    }
}
