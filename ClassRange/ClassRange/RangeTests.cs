using Xunit;

namespace ClassRange
{
    public class RangeTests
    {
        [Fact]
        public void ChecIfTextMatch()
        {
            var choice = new Choice(new Range('a', 'z'));

            Assert.True(choice.Match("b"));
        }

        [Fact]
        public void ChecIfCharIsInRange()
        {
            var choice = new Choice(new Range('c', 'z'));

            Assert.True(choice.Match("b"));
        }

        [Fact]
        public void ChecIfCharsFromATextAreInRange()
        {
            var choice = new Choice(new Range('c', 'z'));

            Assert.True(choice.Match("def"));
        }

        [Fact]
        public void LookIfTextMatchWithGivenRangeUsingAStringWhoIsNotInRange()
        {
            var choice = new Choice(new Range('e', 'z'));

            Assert.False(choice.Match("1ef"));
        }

        [Fact]
        public void LookIfTextMatchWithGivenRangeUsingAnEmptyString()
        {
            var choice = new Choice(new Range('e', 'z'));

            Assert.False(choice.Match(""));
        }
    }
}
