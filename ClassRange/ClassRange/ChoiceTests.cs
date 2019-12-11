using Xunit;

namespace ClassRange
{
    public class ChoiceTests
    {
        [Fact]
        public void CheckDigits()
        {
            var digit = new Choice(
                new Character('0'),
                new Range('1', '9'));

            Assert.True(digit.Match("0159"));
        }
    }
}