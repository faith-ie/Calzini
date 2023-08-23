using Calzini.Core.TwitterSnowflakeConversion;
using System;
using System.Globalization;

namespace Calzini.Core.TwitterTimeStamp
{
    public class TwitterTimeFormat
    {
        public static string ShortTime(long snowflake)
        {
            var st = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string ust = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:t>";
            return $"\nShort time format: " + ust + "\nExample of how it would look: " + st.Hour + ":" + st.Minute;
        }

        public static string LongTime(long snowflake)
        {
            var lt = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string ult = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:T>";
            return $"\nLong time format: " + ult + "\nExample of how it would look: " + lt.Hour + ":" + lt.Minute + ":" + lt.Second;
        }

        public static string ShortDate(long snowflake)
        {
            var sd = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string usd = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:d>";
            return $"\nShort date format: " + usd + "\nExample of how it would look: " + sd.Day + "/" + sd.Month + "/" + sd.Year;
        }

        public static string LongDate(long snowflake)
        {
            var ld = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string uld = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:D>";
            return $"\nLong date format: " + uld + "\nExample of how it would look: " + ld.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ld.Month) + " " + ld.Year;
        }

        public static string ShortDateTime(long snowflake)
        {
            var sdt = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string usdt = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:f>    [This style is default with discord time stamps]";
            return $"\nShort date / Time format: " + usdt + "\nExample of how it would look: " + sdt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(sdt.Month) + " " + sdt.Year + " " + sdt.Hour + ":" + sdt.Minute;
        }

        public static string LongDateTime(long snowflake)
        {
            var ldt = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            string uldt = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:F>";
            return $"\nLong date / Time format: " + uldt + "\nExample of how it would look: " + CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(ldt.DayOfWeek) + ", " + ldt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ldt.Month) + " " + ldt.Year + " " + ldt.Hour + ":" + ldt.Minute;
        }

        public static string RelativeTime(long snowflake)
        {
            var rt = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
            DateTime date1 = new(rt.Year, rt.Month, rt.Day, rt.Hour, rt.Minute, rt.Second);
            DateTime date2 = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            TimeSpan ts;
            if (date1 > date2)
            {
                ts = date1 - date2;
            }
            else
            {
                ts = date2 - date1;
            }
            string urt = $"<t:{TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake)}:R>";
            return $"\nRelative Time format: " + urt + "\nExample of how it would look: " + ts;
        }
    }
}