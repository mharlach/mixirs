using Newtonsoft.Json;

namespace BarLib.Models
{
    public abstract class UserModelBase : StorageObjectBase
    {
        [JsonProperty("userId")]
        public string UserId { get; set; } = string.Empty;

        [JsonProperty("hashCode")]
        public int HashCode { get; set; }
    }

}