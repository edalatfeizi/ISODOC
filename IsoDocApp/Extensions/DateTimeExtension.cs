using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsoDocApp.Extensions
{
    public static class DateTimeExtension
    {
        public static string ToPersianDateTime(this DateTime now)
        {
            var pc = new PersianCalendar();
            int year = pc.GetYear(now);
            int month = pc.GetMonth(now);
            int day = pc.GetDayOfMonth(now);

            return $"{year}/{month.ToString("00")}/{day.ToString("00")}T{now.Hour}:{now.Minute}:{now.Second}";
        }
    }
}
