using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarLib
{
    public class SearchConfiguration
    {
        public string Endpoint { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string DrinkIndexer { get; set; } = string.Empty;
        public string IngredientIndexer { get; set; } = string.Empty;
    }
}
