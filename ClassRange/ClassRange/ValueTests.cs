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
    }
}
