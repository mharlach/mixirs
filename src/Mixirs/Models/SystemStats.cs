using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace BarLib.Models
{
    public class SystemStats
    {
        [JsonProperty("id")]
        public string Id { get; set; } = "STATS";

        [JsonProperty("pk")]
        public string PartitionKey { get; set; } = "STATS";

        [JsonProperty("drinkVersion")]
        public string DrinksVersion { get; set; } = string.Empty;

        [JsonProperty("updated")]
        public DateTime Updated { get; set; } = DateTime.UtcNow;

        [JsonProperty("ingredientCount")]
        public int IngredientCount { get; set; }

        [JsonProperty("DrinkCount")]
        public int DrinkCount { get; set; }

    }
}
