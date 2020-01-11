using Xunit;

namespace ClassRange
{
    public class TextTests
    {
        [Fact]
        public void AplyTextMethodOnAStringreturnTrue()
        {
            var prefix = new Text("pre");

            Assert.True(prefix.Match("preposition").Success());
        }

        [Fact]
        public void AplyTextMethodOnAStringreturnFalse()
        {
            var prefix = new Text("pre");

            Assert.False(prefix.Match("ppreposition").Success());
        }

        [Fact]
        public void ReturnRemainingTextAfterMethodTextIsAplayed()
        {
            var pref = new Text("pre");

            Assert.Equal("position", pref.Match("preposition").RemainingText());
        }

        [Fact]
        public void ReturnRemainingTextAfterMethodTextIsAplayedOnAnEmtyString()
        {
            var pref = new Text("");

            Assert.Equal("preposition", pref.Match("preposition").RemainingText());
        }
    }
}
