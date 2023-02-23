using Calzini.Core.DiscordSnowflakeConversion;
using System;
using System.Globalization;

namespace Calzini.Core.DiscordTimeStamp
{
    public class DiscordTimeFormat
    {
        public static string ShortTime(long snowflake)
        {
            var st = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string ust = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:t>";
            return $"\nShort time format: " + ust + "\nExample of how it would look: " + st.Hour + ":" + st.Minute;
        }

        public static string LongTime(long snowflake)
        {
            var lt = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string ult = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:T>";
            return $"\nLong time format: " + ult + "\nExample of how it would look: " + lt.Hour + ":" + lt.Minute + ":" + lt.Second;
        }

        public static string ShortDate(long snowflake)
        {
            var sd = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string usd = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:d>";
            return $"\nShort date format: " + usd + "\nExample of how it would look: " + sd.Day + "/" + sd.Month + "/" + sd.Year;
        }

        public static string LongDate(long snowflake)
        {
            var ld = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string uld = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:D>";
            return $"\nLong date format: " + uld + "\nExample of how it would look: " + ld.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ld.Month) + " " + ld.Year;
        }

        public static string ShortDateTime(long snowflake)
        {
            var sdt = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string usdt = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:f>    [This style is default with discord time stamps]";
            return $"\nShort date / Time format: " + usdt + "\nExample of how it would look: " + sdt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(sdt.Month) + " " + sdt.Year + " " + sdt.Hour + ":" + sdt.Minute;
        }

        public static string LongDateTime(long snowflake)
        {
            var ldt = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
            string uldt = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:F>";
            return $"\nLong date / Time format: " + uldt + "\nExample of how it would look: " + CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(ldt.DayOfWeek) + ", " + ldt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ldt.Month) + " " + ldt.Year + " " + ldt.Hour + ":" + ldt.Minute;
        }

        public static string RelativeTime(long snowflake)
        {
            var rt = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
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
            string urt = $"<t:{DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake)}:R>";
            return $"\nRelative Time format: " + urt + "\nExample of how it would look: " + ts;
        }
    }
}