using Xunit;

namespace ClassRange
{
    public class RangeTests
    {
        [Fact]
        public void ChecIfTextMatch()
        {
            Range match = new Range('a', 'z');

            Assert.True(match.Match("b"));
        }
    }
}
