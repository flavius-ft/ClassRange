using Xunit;

namespace ClassRange
{
    public class OptionalTests
    {
        [Fact]
        public void AplyOptionalClassOnAgivenStringReturnRemainingText()
        {
            var optional = new Optional(new Character('a'));

            Assert.Equal("bc", optional.Match("abc").RemainingText());
        }
    }
}
