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

        [Fact]
        public void ChecIfCharIsInRange()
        {
            Range match = new Range('c', 'z');

            Assert.False(match.Match("b"));
        }

        [Fact]
        public void ChecIfCharsFromATextAreInRange()
        {
            Range match = new Range('c', 'z');

            Assert.False(match.Match("def"));
        }
    }
}
