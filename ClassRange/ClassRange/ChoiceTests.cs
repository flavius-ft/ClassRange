using Xunit;

namespace ClassRange
{
    public class ChoiceTests
    {
        [Fact]
        public void CheckDigits()
        {
            var digits = new IPattern[]
            {
                new Character('0'), new Range('1', '9')
            };

            Assert.True(digits.)
        }
    }
}
