using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;

namespace BarLib.Models
{
    public class DrinkIngredient
    {
        public DrinkIngredient() { }

        public DrinkIngredient(string ingredientId, float quantity, string units)
        {
            this.Id = ingredientId;
            this.Quantity = quantity;
            this.Units = units;
        }

        [JsonProperty("quantity")]
        public float Quantity { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; } = string.Empty;

        [JsonProperty("ingredientId")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("ingredientName")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("optional")]
        public bool Optional { get; set; } = false;

        [JsonProperty("modification")]
        public string Modification { get; set; } = string.Empty;

    }
}
