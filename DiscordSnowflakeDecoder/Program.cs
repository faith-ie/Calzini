using System;
using System.Threading.Tasks;

namespace DiscordSnowflakeDecoder
{
    internal class Program
    {
        private static async Task Main() => await SnowFlake();

        private static async Task SnowFlake()
        {
            Console.WriteLine("What is your Discord Snowflake you would like decoded?");
            long.TryParse(Console.ReadLine(), out var snowflake);
            var amongus = DiscordDecoder.DecodeSnowflake(snowflake);
            var postUnixTime = DiscordDecoder.GetUnixTimeFromSnowflake(snowflake);
            Console.WriteLine("Discord snowflake generated on: {0}", amongus);
            Console.WriteLine("Unix timestamp: {0}", postUnixTime);
            await Task.CompletedTask;
        }
    }
}