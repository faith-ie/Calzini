using Calzini.Core.DiscordSnowflakeConversion;
using Calzini.Core.DiscordTimeStamp;
using Calzini.Core.TwitterSnowflakeConversion;
using System;
using System.Threading.Tasks;

namespace Calzini
{
    internal class Program
    {
        private static async Task Main() => await SnowFlake();

        private static async Task SnowFlake()
        {
            Console.Write("Would you like to decode a Twitter snowflake, or a Discord snowflake?\n1. Discord\n2. Twitter");
            int userInput;
            int.TryParse(Console.ReadLine(), out userInput);
            switch (userInput)
            {
                case 1:
                    Console.WriteLine("What is your Discord Snowflake you would like decoded?");
                    long.TryParse(Console.ReadLine(), out var snowflake);
                    var amongus = DiscordDecoder.DecodeDiscordSnowflake(snowflake);
                    var postUnixTime = DiscordDecoder.GetUnixTimeFromDiscordSnowflake(snowflake);
                    Console.WriteLine("Discord snowflake generated on: {0}", amongus);
                    Console.WriteLine("Unix timestamp: {0}", postUnixTime);
                    Console.WriteLine(DiscordTimeFormat.ShortTime(snowflake));
                    Console.WriteLine(DiscordTimeFormat.LongTime(snowflake));
                    Console.WriteLine(DiscordTimeFormat.ShortDate(snowflake));
                    Console.WriteLine(DiscordTimeFormat.LongDate(snowflake));
                    Console.WriteLine(DiscordTimeFormat.ShortDateTime(snowflake));
                    Console.WriteLine(DiscordTimeFormat.LongDateTime(snowflake));
                    Console.WriteLine(DiscordTimeFormat.RelativeTime(snowflake));
                    break;

                case 2:
                    Console.WriteLine("What is your Twitter Snowflake you would like decoded?");
                    long.TryParse(Console.ReadLine(), out snowflake);
                    amongus = TwitterDecoder.DecodeTwitterSnowflake(snowflake);
                    postUnixTime = TwitterDecoder.GetUnixTimeFromTwitterSnowflake(snowflake);
                    Console.WriteLine("Twitter snowflake generated on: {0}", amongus);
                    Console.WriteLine("Unix timestamp: {0}", postUnixTime);
                    Console.WriteLine("\t\t --- The Twitter stuff isn't done yet, I will do the twitter unix timestamp stuff later ---");
                    break;

                default:
                    Console.WriteLine("You need to pick either 1 or 2!");
                    break;
            }
            await Task.CompletedTask;
        }
    }
}