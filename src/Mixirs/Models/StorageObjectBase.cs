using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;

namespace Mixirs.Models
{
    public abstract class StorageObjectBase : IValidatableObject
    {
        [SearchableField(IsKey = true, IsFilterable = true)]
        [Required]
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [FieldBuilderIgnore]
        [JsonProperty("pk")]
        public string PartitionKey { get; set; } = string.Empty;

        [SimpleField(IsFilterable = true, IsSortable = true)]
        [JsonProperty("created")]
        public DateTime Created { get; set; } = DateTime.UtcNow;

        [SimpleField(IsFilterable = true, IsSortable = true)]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; } = DateTime.UtcNow;

        [FieldBuilderIgnore]
        [JsonProperty("type")]
        public abstract string ObjectType { get; set; }

        [JsonProperty("softDelete")]
        public bool SoftDelete { get; set; } = false;

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) => new List<ValidationResult>();

    }

}