using Xunit;

namespace ClassRange
{
    public class OneOrMoreTests
    {
        [Fact]
        public void UseOneOrMoreClassOnAGivenStringReturnRemainingText()
        {
            var oneOrMore = new OneOrMore(new Range('0', '9'));

            Assert.Equal("ab", oneOrMore.Match("123ab").RemainingText());
        }
    }
}
