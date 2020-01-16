using Xunit;

namespace ClassRange
{
    public class NumberTest
    {
        [Fact]
        public void VerifyJsonNUmbersReturningRemainingText()
        {
            var number = new Number();

            Assert.Equal("ab3", number.Match("123ab3").RemainingText());
        }
    }
}
