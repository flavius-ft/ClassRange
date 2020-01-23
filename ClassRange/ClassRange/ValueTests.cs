using Xunit;

namespace ClassRange
{
    public class ValueTests
    {
        [Fact]
        public void CheckAnArrayInClassValue()
        {
            var array = new Value();

            Assert.Equal("", array.Match("[1,2,3]").RemainingText());
        }

        [Fact]
        public void CheckAMixtArrayInClassValue()
        {
            var array = new Value();

            Assert.Equal("", array.Match("[ 1, \"a\", true]").RemainingText());
        }

        [Fact]
        public void CheckAnArrayWithWhiteSpacesInClassValue()
        {
            var array = new Value();

            Assert.Equal("", array.Match("[ 1, 2, 3]").RemainingText());
        }

        [Fact]
        public void CheckAnArrayWithWithStringsWhiteSpacesInClassValue()
        {
            var array = new Value();

            Assert.Equal("", array.Match("[ \"a\", \"b\", \"c\"]").RemainingText());
        }

        [Fact]
        public void CheckAStringInClassValue()
        {
            var strings = new Value();

            Assert.Equal("", strings.Match("\"this is a string\"").RemainingText());
        }

        [Fact]
        public void CheckANumberInClassValue()
        {
            var number = new Value();

            Assert.Equal("", number.Match("-12.23e+5").RemainingText());
        }

        [Fact]
        public void CheckATextInClassValue()
        {
            var text = new Value();

            Assert.Equal("", text.Match("true").RemainingText());
        }
    }
}
