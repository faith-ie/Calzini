using System;
using System.Threading.Tasks;

namespace DiscordSnowflakeDecoder
{
    public class DiscordDecoder
    {
        public static async Task<DateTime> DecodeSnowflake(ulong discordSnowflake)
        {
            ulong discordEpochMS = 1420070400000;
            return (DateTime)((discordSnowflake >> 22) + discordEpochMS);
        }
    }
}