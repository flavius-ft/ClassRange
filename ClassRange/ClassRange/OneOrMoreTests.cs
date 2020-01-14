using Xunit;

namespace ClassRange
{
    public class OneOrMoreTests
    {
        [Fact]
        public void UseOneOrMoreClassWithRangeOnAGivenStringReturnRemainingText()
        {
            var oneOrMore = new OneOrMore(new Range('0', '9'));

            Assert.Equal("ab", oneOrMore.Match("123ab").RemainingText());
        }

        [Fact]
        public void UseOneOrMoreClassWithCharacterOnAGivenStringReturnRemainingText()
        {
            var oneOrMore = new OneOrMore(new Character('a'));

            Assert.Equal("b", oneOrMore.Match("aaab").RemainingText());
        }

        [Fact]
        public void UseOneOrMoreClassWithSequenceOnAGivenStringReturnRemainingText()
        {
            var oneOrMore = new OneOrMore(new Sequence(
                new Character('u'),
                new Range('0', '9'),
                new Range('0', '9')));

            Assert.Equal("b", oneOrMore.Match("u12b").RemainingText());
        }
    }
}
