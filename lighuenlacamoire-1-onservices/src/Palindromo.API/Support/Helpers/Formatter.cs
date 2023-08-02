using System.Globalization;
using System.Linq;
using System.Text;

namespace Palindromo.API.Support.Helpers
{
    public static class Formatter
    {
        public static string NormalizeFormat(this string value)
        {
            if (string.IsNullOrEmpty(value)) return "";
            var chars = value
                .ToLower()
                .Normalize(NormalizationForm.FormD)
                .ToCharArray()
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
                .ToArray();

            return new string(chars);
        }
    }
}
