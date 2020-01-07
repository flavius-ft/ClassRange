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

            Assert.True(digit.Match("0159").Success());
        }

        [Fact]
        public void CheckDigitsWithOutZero()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.True(digit.Match("159").Success());
        }

        [Fact]
        public void UseMatchOnAStringWithNumberAndALetter()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.False(digit.Match("a9").Success());
        }

        [Fact]
        public void UseMatchToAnEmptyString()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.False(digit.Match("").Success());
        }

        [Fact]
        public void UseMatchForANullString()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            const string nullString = null;

            Assert.False(digit.Match(nullString).Success());
        }

        [Fact]
        public void CheckHexaDigits()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));

            Assert.True(digit.Match("a9").Success());
        }
    }
}