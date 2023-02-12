using System;

namespace DiscordSnowflakeDecoder
{
    public class DiscordDecoder
    {
        public static DateTime DecodeSnowflake(long discordSnowflake)
        {
            DateTime discordEpoch = new DateTime(2015, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var e = discordEpoch.AddMilliseconds(discordSnowflake >> 22).ToLocalTime();
            return e;
        }
    }
}