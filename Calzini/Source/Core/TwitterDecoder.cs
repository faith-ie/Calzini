using System;

namespace Calzini.Core.TwitterSnowflakeConversion
{
    public class TwitterDecoder
    {
        public static DateTime DecodeTwitterSnowflake(long twitterSnowflake)
        {
            DateTime twitterEpoch = new(2010, 11, 4, 1, 42, 54, DateTimeKind.Utc);
            var e = twitterEpoch.AddMilliseconds(twitterSnowflake >> 22).ToLocalTime();
            return e;
        }

        public static long GetUnixTimeFromTwitterSnowflake(long twitterSnowFlake)
        {
            return ((twitterSnowFlake >> 22) + 1288834974657) / 1000;
        }
    }
}

// A bit of a gripe here, for some reason, twitter doesn't publicly say, or at least make it extremely obvious when their snowflake epoch is, so I had to download the source code for the originaal Twitter snowflake repo and find it from that.
// For the record, the Twitter snowflake epoch is 1288834974657. I don't know why they wouldn't make it obvious but, whatever. 