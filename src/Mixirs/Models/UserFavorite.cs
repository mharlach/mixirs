using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Mixirs.Models
{
    public class UserFavorite
    {
        [Required]
        [JsonProperty("rating")]
        public int Rating { get; set; } = 0;

        [Required]
        [JsonProperty("drinkId")]
        public string DrinkId { get; set; } = string.Empty;
    }
}