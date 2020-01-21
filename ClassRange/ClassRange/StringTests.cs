using Xunit;

namespace ClassRange
{
    public class StringTests
    {
        [Fact]
        public void TestStringClassWithSimpleString()
        {
            var text = new String();

            Assert.Equal("", text.Match("\"abc\"").RemainingText());
        }

        [Fact]
        public void TestStringClassWithComplexString()
        {
            var text = new String();

            Assert.Equal("", text.Match("\"a\\u0015b\\n c\"").RemainingText());
        }
    }
}
