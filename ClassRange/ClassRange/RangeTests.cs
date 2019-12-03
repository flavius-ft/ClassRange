using Xunit;

namespace ClassRange
{
    public class RangeTests
    {
        [Fact]
        public void ChecIfTextMatch()
        {
            Range range = new Range('a', 'z');

            Assert.True(range.Match("b"));
        }

        [Fact]
        public void ChecIfCharIsInRange()
        {
            Range range = new Range('c', 'z');

            Assert.False(range.Match("b"));
        }

        [Fact]
        public void ChecIfCharsFromATextAreInRange()
        {
            Range range = new Range('c', 'z');

            Assert.True(range.Match("def"));
        }
    }
}
