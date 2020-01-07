using Xunit;

namespace ClassRange
{
    public class SequenceTests
    {
        [Fact]
        void CheckSequenceMethodWithTwoCharsReturnTrue()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('b'));

            Assert.True(digit.Match("abcd").Success());
        }

        [Fact]
        void CheckSequenceMethodWithTwoCharsreturnRemainingText()
        {
            var digit = new Sequence(
                new Character('a'),
                new Character('b'));

            Assert.Equal("cd", digit.Match("abcd").RemainingText());
        }
    }
}
