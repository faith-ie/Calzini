using System.Globalization;

namespace Calzini
{
    public class TimeFormat
    {
        public static string ShortTime(long snowflake)
        {
            var st = DiscordDecoder.DecodeSnowflake(snowflake);
            string ust = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:t>";
            return $"\nShort time format: " + ust + "\nExample of how it would look: " + st.Hour + ":" + st.Minute;
        }

        public static string LongTime(long snowflake)
        {
            var lt = DiscordDecoder.DecodeSnowflake(snowflake);
            string ult = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:T>";
            return $"\nLong time format: " + ult + "\nExample of how it would look: " + lt.Hour + ":" + lt.Minute + ":" + lt.Second;
        }

        public static string ShortDate(long snowflake)
        {
            var sd = DiscordDecoder.DecodeSnowflake(snowflake);
            string usd = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:d>";
            return $"\nShort date format: " + usd + "\nExample of how it would look: " + sd.Day + "/" + sd.Month + "/" + sd.Year;
        }

        public static string LongDate(long snowflake)
        {
            var ld = DiscordDecoder.DecodeSnowflake(snowflake);
            string uld = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:D>";
            return $"\nLong date format: " + uld + "\nExample of how it would look: " + ld.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ld.Month) + " " + ld.Year;
        }

        public static string ShortDateTime(long snowflake)
        {
            var sdt = DiscordDecoder.DecodeSnowflake(snowflake);
            string usdt = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:f>    [This style is default with discord time stamps]";
            return $"\nShort date / Time format: " + usdt + "\nExample of how it would look: " + sdt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(sdt.Month) + " " + sdt.Year + " " + sdt.Hour + ":" + sdt.Minute;
        }

        public static string LongDateTime(long snowflake)
        {
            var ldt = DiscordDecoder.DecodeSnowflake(snowflake);
            string uldt = $"<t:{DiscordDecoder.GetUnixTimeFromSnowflake(snowflake)}:F>";
            return $"\nLong date / Time format: " + uldt + "\nExample of how it would look: " + CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(ldt.DayOfWeek) + ", " + ldt.Day + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(ldt.Month) + " " + ldt.Year + " " + ldt.Hour + ":" + ldt.Minute;
        }
    }
}