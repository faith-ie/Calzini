using System;
namespace Calzini.Core.DiscordSnowflakeConversion
{
    public class DiscordDecoder
    {
        public static DateTime DecodeDiscordSnowflake(long discordSnowflake)
        {
            DateTime discordEpoch = new(2015, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var e = discordEpoch.AddMilliseconds(discordSnowflake >> 22).ToLocalTime();
            return e;
        }

        public static long GetUnixTimeFromDiscordSnowflake(long discordSnowFlake)
        {
            return ((discordSnowFlake >> 22) + 1420070400000) / 1000;
        }
    }
}