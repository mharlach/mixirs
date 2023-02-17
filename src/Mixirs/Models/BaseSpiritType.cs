using System;
using System.Linq;

namespace BarLib.Models
{
    public class BaseSpiritType
    {
        public const string Rum = "rum";
        public const string Gin = "gin";
        public const string Vodka = "vodka";
        public const string Whiskey = "whisk(e)y";
        public const string Brandy = "brandy";
        public const string Tequila = "tequila";
        public const string Mezcal = "mezcal";
        public const string Combination = "combination";
        public const string Other = "other";


        public static string[] GetAll() => new[] { Rum, Gin, Vodka, Whiskey, Brandy, Tequila, Mezcal, Combination, Other };

        public static bool TryGetValid(string input, out string validated)
        {
            validated = GetAll().Where(x => x.Equals(input, StringComparison.OrdinalIgnoreCase)).FirstOrDefault() ?? string.Empty;
            return !string.IsNullOrWhiteSpace(validated);
        }
    }

}
