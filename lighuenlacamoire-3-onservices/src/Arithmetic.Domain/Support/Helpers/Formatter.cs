using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arithmetic.Domain.Support.Helpers
{
    public static class Formatter
    {
        public static string ToInvariant(this double value)
        {
            return value.ToString(CultureInfo.InvariantCulture);
        }
        public static double FromString(this string value)
        {
            double.TryParse(value, NumberStyles.Any, CultureInfo.InvariantCulture, out double number);
            return number;
        }
    }
}
