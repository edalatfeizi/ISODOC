using System;
using System.Collections.Generic;
using System.Globalization;
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

        public static string FormatPersianDate(this string input)
        {
            PersianCalendar PersianCal = new PersianCalendar();
            CultureInfo PersianCulture = new CultureInfo("fa-IR")
            {
                DateTimeFormat = { Calendar = PersianCal }
            };
            var date =  DateTime.Parse(input, PersianCulture);

            int year = PersianCal.GetYear(date);
            int month = PersianCal.GetMonth(date);
            int day = PersianCal.GetDayOfMonth(date);
            int hour = PersianCal.GetHour(date);
            int minute = PersianCal.GetMinute(date);
            int second = PersianCal.GetSecond(date);

            return $"{hour:00}:{minute:00}:{second:00} {year}/{month:00}/{day:00}";
        }
     
        public static bool IsDeveloper(this string personCode)
        {
            return Constants.DeveloperPersonCodes.Any(x => x == personCode);
        }
    }
}
