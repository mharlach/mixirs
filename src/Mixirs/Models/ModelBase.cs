using System.ComponentModel.DataAnnotations;
using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;

namespace Mixirs.Models
{

    public abstract class ModelBase : StorageObjectBase
    {
        [SearchableField(IsFilterable = true, IsSortable = true)]
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;


    }

}