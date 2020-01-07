using Xunit;

namespace ClassRange
{
    public class RangeTests
    {
        [Fact]
        public void ChecIfTextMatch()
        {
            var choice = new Choice(new Range('a', 'z'));

            Assert.True(choice.Match("b").Success());
        }

        [Fact]
        public void ChecIfCharIsInRange()
        {
            var choice = new Choice(new Range('c', 'z'));

            Assert.False(choice.Match("b").Success());
        }

        [Fact]
        public void ChecIfCharsFromATextAreInRange()
        {
            var choice = new Choice(new Range('c', 'z'));

            Assert.True(choice.Match("def").Success());
        }

        [Fact]
        public void LookIfTextMatchWithGivenRangeUsingAStringWhoIsNotInRange()
        {
            var choice = new Choice(new Range('e', 'z'));

            Assert.False(choice.Match("1ef").Success());
        }

        [Fact]
        public void LookIfTextMatchWithGivenRangeUsingAnEmptyString()
        {
            var choice = new Choice(new Range('e', 'z'));

            Assert.False(choice.Match("").Success());
        }
    }
}
