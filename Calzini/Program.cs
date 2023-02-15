using Calzini.Core.DiscordSnowflakeConversion;
using Calzini.Core.DiscordTimeStamp;
using System;
using System.Threading.Tasks;

namespace Calzini
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
            Console.WriteLine(TimeFormat.ShortTime(snowflake));
            Console.WriteLine(TimeFormat.LongTime(snowflake));
            Console.WriteLine(TimeFormat.ShortDate(snowflake));
            Console.WriteLine(TimeFormat.LongDate(snowflake));
            Console.WriteLine(TimeFormat.ShortDateTime(snowflake));
            Console.WriteLine(TimeFormat.LongDateTime(snowflake));
            await Task.CompletedTask;
        }
    }
}