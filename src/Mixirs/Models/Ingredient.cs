using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Mixirs.Models
{

    public class Ingredient : ModelBase
    {
        public Ingredient() { }

        [SearchableField(IsFilterable = true)]
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [SearchableField(IsFacetable = true, IsFilterable = true, IsSortable = true)]
        [Required]
        [JsonProperty("ingredientType")]
        public string IngredientType { get; set; } = Models.IngredientType.Unknown;

        [SimpleField(IsFacetable = true, IsFilterable = true, IsSortable = true)]
        [JsonProperty("count")]
        public int Count { get; set; }

        [SearchableField(IsFacetable = true, IsFilterable = true, IsSortable = true)]
        [JsonProperty("baseType")]
        public string BaseType { get; set; } = string.Empty;

        [FieldBuilderIgnore]
        public override string ObjectType { get; set; } = "ingredient";

        [SearchableField(IsFacetable = true, IsFilterable = true)]
        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string>();
    }
}
