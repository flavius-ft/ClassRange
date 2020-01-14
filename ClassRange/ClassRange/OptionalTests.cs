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

        [Fact]
        public void AplyOptionalClassWithSequenceOnAGivenStringReturnRemainingText()
        {
            var optional = new Optional(new Sequence(
                new Character('u'),
                new Range('0', '9'),
                new Range('0', '9')));

            Assert.Equal("bc", optional.Match("u12bc").RemainingText());
        }
    }
}
