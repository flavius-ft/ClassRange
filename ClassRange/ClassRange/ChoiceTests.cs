using Xunit;

namespace ClassRange
{
    public class ChoiceTests
    {
        [Fact]
        public void CheckDigitsWithZeroFirst()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.True(digit.Match("0159"));
        }

        [Fact]
        public void CheckDigitsWithOutZero()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.True(digit.Match("159"));
        }

        [Fact]
        public void UseMatchOnAStringWithNumberAndALetter()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.False(digit.Match("a9"));
        }

        [Fact]
        public void UseMatchToAnEmptyString()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.False(digit.Match(""));
        }

        [Fact]
        public void UseMatchForANullString()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            const string nullString = null;

            Assert.False(digit.Match(nullString));
        }
    }
}