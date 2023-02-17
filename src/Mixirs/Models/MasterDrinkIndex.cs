using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mixirs.Models
{
    public  class MasterDrinkIndex
    {
        public const string MasterDrinkIndexName = "MasterIndex";

        [Required]
        [JsonProperty("id")]
        public string Id { get; set; } = MasterDrinkIndexName;
        
        [JsonProperty("pk")]
        public string PartitionKey { get; set; } = MasterDrinkIndexName;
        public string Version { get; set; } = string.Empty;
        public List<DrinkIndexEntry> DrinkEntries { get; set; } = new List<DrinkIndexEntry>();

        public void Upsert(Drink drink)
        {
            bool updated = false;
            foreach(var entry in DrinkEntries)
            {
                if(entry.Id.Equals(drink.Id, StringComparison.OrdinalIgnoreCase))
                {
                    entry.Name = drink.Name;
                    entry.Ingredients = drink.Ingredients.Where(x=>!x.Optional).Select(x=>x.Id).ToList();
                    updated = true;
                    break;
                }
            }

            if (!updated)
            {
                DrinkEntries.Add(new DrinkIndexEntry
                {
                    Id = drink.Id,
                    Name = drink.Name,
                    Ingredients = drink.Ingredients.Where(x=>!x.Optional).Select(x => x.Id).ToList(),
                });
            }
        }

        public void Remove(string drinkId)
        {
            DrinkEntries = DrinkEntries.Where(x=>x.Id != drinkId).ToList();
        }
    }

    public class DrinkIndexEntry
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public List<string> Ingredients { get; set; } = new List<string>();

    }
}
