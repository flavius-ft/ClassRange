using Xunit;

namespace ClassRange
{
    public class ListTests
    {
        [Fact]
        public void UseListMethodReturnRemainingText()
        {
            var a = new List(new Range('0', '9'), new Character(','));

            Assert.Equal(",", a.Match("1,2,3,").RemainingText());
        }

        [Fact]
        public void UseListMethodWithStringReturnRemainingText()
        {
            var a = new List(new Range('0', '9'), new Character(','));

            Assert.Equal("a", a.Match("1a").RemainingText());
        }

        [Fact]
        public void UseListMethodWithComplexStringReturnRemainingText()
        {
            var digits = new OneOrMore(new Range('0', '9'));
            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequence(whitespace, new Character(';'), whitespace);
            var list = new List(digits, separator);

            Assert.Equal("", list.Match("1; 22;\n 333 \t; 22").RemainingText());
        }
    }
}
