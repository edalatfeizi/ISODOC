using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Extensions
{
    public static class StringExtensions
    {
        public static string NormalizePersian(this string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            return input
                .Replace("ي", "ی")  // Arabic Yeh to Persian Yeh
                .Replace("ك", "ک")  // Arabic Kaf to Persian Kaf
                .Replace("ة", "ه")  // Arabic Teh Marbuta to Heh
                .Replace("أ", "ا")  // Arabic Alef with Hamza to Alef
                .Replace("إ", "ا") // Arabic Alef with Hamza Below to Alef
                .Replace("ؤ", "و") // Arabic Waw with Hamza to Waw
                .Replace("ئ", "ی"); // Arabic Yeh with Hamza to Yeh
        }
    }
}
