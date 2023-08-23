using Calzini.Core.DiscordTimeStamp;
using Xunit;

namespace Tests
{
    public class DiscordTestSuite
    {
        [Theory]
        [InlineData(301379068941828096)]
        public void ShortTimeFormatTest(long snowflake)
        {
            var o = DiscordTimeFormat.ShortDateTime(snowflake);
            Assert.Contains("Short date / Time format: ", o);
        }
    }
}