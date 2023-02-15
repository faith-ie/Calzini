using System;

namespace Calzini.Core
{
    public class DiscordDecoder
    {
        public static DateTime DecodeSnowflake(long discordSnowflake)
        {
            DateTime discordEpoch = new DateTime(2015, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var e = discordEpoch.AddMilliseconds(discordSnowflake >> 22).ToLocalTime();
            return e;
        }

        public static long GetUnixTimeFromSnowflake(long discordSnowFlake)
        {
            return ((discordSnowFlake >> 22) + 1420070400000) / 1000;
        }
    }
}