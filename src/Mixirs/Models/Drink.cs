using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Search.Documents.Indexes;
using Newtonsoft.Json;

namespace Mixirs.Models
{

    public class Drink : ModelBase
    {
        public Drink() { }

        public Drink(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }


        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("ingredients")]
        public List<DrinkIngredient> Ingredients { get; set; } = new List<DrinkIngredient>();

        [JsonProperty("steps")]
        public List<string> Steps { get; set; } = new List<string>();

        public override string ObjectType { get; set; } = ObjectTypes.DrinkType;

        [JsonProperty("src")]
        public string ReferenceSource => ReferenceSources.FirstOrDefault() ?? String.Empty;

        [JsonProperty("referenceSources")]
        public List<string> ReferenceSources { get; set; } = new List<string>();

        [JsonProperty("ingredientCount")]
        public int IngredientCount
        {
            get { return Ingredients.Count; }
        }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; } = new List<string>();

        [JsonProperty("baseSpirit")]
        public string BaseSpirit { get; set; } = BaseSpiritType.Other;

        [JsonProperty("similarTo")]
        public List<string> SimilarTo { get; set; } = new List<string>();

        public void AddStep(string IngredientId, float quantity, string units) => Ingredients.Add(new DrinkIngredient(IngredientId, quantity, units));

        public IEnumerable<string> GetIngredients() => Ingredients.Select(x => x.Id);

        public string ToShortDescription()
        {
            var desc = string.Join(", ", Ingredients.Take(3).Select(x => x.Name)); 
            if (Ingredients.Count > 3)
            {
                return $"{desc}...";
            }

            return desc;
        }

        public bool ContainsIngredient(string ingredientId) => Ingredients.Any(x => x.Id.Equals(ingredientId, System.StringComparison.OrdinalIgnoreCase));
    }
}
