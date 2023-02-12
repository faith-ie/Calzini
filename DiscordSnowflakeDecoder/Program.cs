using System;
using System.Threading.Tasks;

namespace DiscordSnowflakeDecoder
{
    internal class Program
    {
        private static async Task Main() => await MainAsync();

        private static async Task MainAsync()
        {
            Console.WriteLine("What is your Discord Snowflake you would like decoded?");
            ulong.TryParse(Console.ReadLine(), out var snowflake);
            Console.WriteLine(await DiscordDecoder.DecodeSnowflake(snowflake));
        }
    }
}