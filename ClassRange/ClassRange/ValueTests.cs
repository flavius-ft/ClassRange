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

        [Fact]
        public void CheckAnObjectInClassValue()
        {
            var objectV = new Value();

            Assert.Equal("", objectV.Match("{\"latitude\": -78.75, \"longitude\": 20.4}").RemainingText());
        }

        [Fact]
        public void CheckAnObjectWithMultipleObjectsInClassValue()
        {
            var text = new Value();

            Assert.Equal("", text.Match("{\"m\": {\r\n \"i\": \"e\",\r\n\"a\": \"i\"}}").RemainingText());
        }

        [Fact]
        public void CheckAnObjectWithAnArrayOfObjectsInClassValue()
        {
            var text = new Value();

            Assert.Equal("", text.Match("{\"m\": {\r\n \"d\": \"i\",\r\n\"a\": \"i\",\r\n  \"p\": {\r\n    \"m\": [{\"a\": \"N\", \"o\": \"C()\"},{\"a\": \"O\", \"o\": \"O\"}]}}}").RemainingText());
        }

        [Fact]
        public void CheckAnObjectWithAnArrayInClassValue()
        {
            var text = new Value();

            Assert.Equal("", text.Match("{\"m\": [{ \"v\": \"N\", \"o\": \"C()\"}, { \"v\": \"O\", \"o\": \"D()\"},{ \"v\": \"C\", \"o\": \"D()\"}]}").RemainingText());
        }
    }
}
