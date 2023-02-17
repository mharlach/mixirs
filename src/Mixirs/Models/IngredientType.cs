using System;
using System.Linq;

namespace BarLib.Models
{
    // public enum IngredientType
    // {
    //     Spirit,
    //     Adjunct,
    //     Bitters,
    //     Syrup,
    //     Produce,
    //     Pantry,
    //     Garnish,
    //     Liqueur,
    //     Beer,
    //     Wine,
    //     Tea,
    //     Unknown
    // }

    public class IngredientType
    {
        public const string Spirit = "Spirit";
        public const string Adjunct = "Adjunct";
        public const string Bitters = "Bitters";
        public const string Syrup = "Syrup";
        public const string Produce = "Produce";
        public const string Pantry = "Pantry";
        public const string Garnish = "Garnish";
        public const string Liqueur = "Liqueur";
        public const string Beer = "Beer";
        public const string Wine = "Wine";
        public const string Tea = "Tea";
        public const string Unknown = "Unknown";

        public static string[] GetAll() => new[] { Spirit, Adjunct, Bitters, Syrup, Produce, Pantry, Garnish, Liqueur, Beer, Wine, Tea, Unknown };

        public static bool IsValid(string input) => GetAll().Contains(input, StringComparer.OrdinalIgnoreCase);
        public static bool Contains(string input) => IsValid(input);

        public static bool TryGetValid(string input, out string validated)
        {
            validated = GetAll().Where(x => x.Equals(input, StringComparison.OrdinalIgnoreCase)).FirstOrDefault() ?? string.Empty;
            return !string.IsNullOrWhiteSpace(validated);
        }
    }

}
