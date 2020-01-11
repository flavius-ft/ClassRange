using Xunit;

namespace ClassRange
{
    public class AnyTests
    {
        [Fact]
        public void CheckIfFirstLetterIsInAcceptedStringReturnTrue()
        {
            var text = new Any("eE");

            Assert.True(text.Match("ea").Success());
        }

        [Fact]
        public void CheckIfFirstLetterIsInAcceptedStringReturnFalse()
        {
            var text = new Any("eE");

            Assert.False(text.Match("ae").Success());
        }

        [Fact]
        public void CheckMethodAnyReturningRemainingText()
        {
            var text = new Any("ab");

            Assert.Equal("cd", text.Match("acd").RemainingText());
        }
    }
}
