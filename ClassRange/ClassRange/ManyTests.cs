using Xunit;

namespace ClassRange
{
    public class ManyTests
    {
        [Fact]
        public void CheckSameCharIntoAGivenTextReturnRemainingText()
        {
            var many = new Many(new Character('a'));

            Assert.Equal("bc", many.Match("aaabc").RemainingText());
        }

        [Fact]
        public void CheckRangeIntoAGivenTextReturnRemainingText()
        {
            var many = new Many(new Range('0', '9'));

            Assert.Equal("bc567", many.Match("1234bc567").RemainingText());
        }
    }
}
