using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Helpers
{
    public class PersianDateParser
    {
        private static readonly PersianCalendar PersianCal = new PersianCalendar();
        private static readonly CultureInfo PersianCulture = new CultureInfo("fa-IR")
        {
            DateTimeFormat = { Calendar = PersianCal }
        };

        public static DateTime ParsePersianDateTime(string persianDate)
        {
            return DateTime.Parse(persianDate, PersianCulture);
        }

        public static string GetPersianDateParts(DateTime date)
        {
            int year = PersianCal.GetYear(date);
            int month = PersianCal.GetMonth(date);
            int day = PersianCal.GetDayOfMonth(date);
            int hour = PersianCal.GetHour(date);
            int minute = PersianCal.GetMinute(date);
            int second = PersianCal.GetSecond(date);

            return $"{hour:00}:{minute:00}:{second:00} {year}/{month:00}/{day:00}";
        }
    }
}
