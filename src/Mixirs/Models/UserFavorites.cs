using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace BarLib.Models
{
    public class UserFavorites : UserModelBase
    {
        [JsonProperty("favorites")]
        public List<UserFavorite> Favorites {get;set;} = new List<UserFavorite>();

        [JsonProperty("bookmarks")]
        public List<string> Bookmarks {get;set;} = new List<string>();
        
        [JsonProperty("type")]
        public override string ObjectType {get;set;} = ObjectTypes.UserFavoritesType;
    }
}