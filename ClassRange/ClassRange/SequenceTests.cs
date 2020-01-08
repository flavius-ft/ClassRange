using Xunit;

namespace ClassRange
{
    public class SequenceTests
    {
        [Fact]
        public void CheckSequenceMethodWithTwoCharsReturnTrue()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('b'));

            Assert.True(digit.Match("abcd").Success());
        }

        [Fact]
        public void CheckSequenceMethodWithTwoCharsreturnRemainingText()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('b'));

            Assert.Equal("cd", digit.Match("abcd").RemainingText());
        }

        [Fact]
        public void CheckSequenceMethodWithTwoCharsReturnFalse()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('x'));

            Assert.False(digit.Match("abcd").Success());
        }

        [Fact]
        public void CheckSequenceMethodWithTwoCharsReturnFullText()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('b'));

            Assert.Equal("ax", digit.Match("ax").RemainingText());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodReturnTrue()
        {
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.True(hexSeq.Match("uabcdef").Success());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodReturnRemainingText()
        {
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.Equal("ef", hexSeq.Match("uabcdef").RemainingText());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodWhenCharUIsMissingReturnFalse()
        {
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.False(hexSeq.Match("abc").Success());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodWhenIsFalseReturnningFullText()
        {
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.Equal("abc", hexSeq.Match("abc").RemainingText());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodRWithEmptyStringReturnEmptyString()
        {
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.Equal("", hexSeq.Match("").RemainingText());
        }

        [Fact]
        public void UseHexDigitsOnSequenceMethodWithNullStringReturnNullString()
        {
            const string isNull = null;
            var hex = new Choice(
               new Range('0', '9'),
               new Range('a', 'f'),
               new Range('A', 'F'));

            var hexSeq = new Sequence(
                new Character('u'),
                new Sequence(
                    hex,
                    hex,
                    hex,
                    hex));

            Assert.Equal(null, hexSeq.Match(isNull).RemainingText());
        }
    }
}
