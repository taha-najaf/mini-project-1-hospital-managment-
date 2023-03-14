using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_project_1_hospital_managment_
{
    public static class PersianCallender
    {
        public static string ToPersianDateTime(this DateTime dt)
        {
            PersianCalendar pr = new PersianCalendar();
            int year = pr.GetYear(dt);
            int month = pr.GetMonth(dt);
            int day = pr.GetDayOfMonth(dt);
            int hour = pr.GetHour(dt);
            int minute = pr.GetMinute(dt);
            int second = pr.GetSecond(dt);

            return $"{year}/{month}/{day} {hour}:{minute}:{second}";

        }
    }
}
