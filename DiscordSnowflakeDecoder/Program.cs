using System;
using System.Threading.Tasks;

namespace DiscordSnowflakeDecoder
{
    internal class Program
    {
        private static Task Main() => SnowFlake();

        private static async Task SnowFlake()
        {
            Console.WriteLine("What is your Discord Snowflake you would like decoded?");
            long.TryParse(Console.ReadLine(), out var snowflake);
            var amongus = DiscordDecoder.DecodeSnowflake(snowflake);
            Console.WriteLine(amongus);
            await Task.CompletedTask;
        }
    }
}