namespace ClassRange
{
    class Value : IPattern
    {
        private readonly IPattern pattern;

        public Value()
        {
            // aici construiește patternul pentru
            // un JSON value
            // ai grijă să ți seama de `spații albe`
            var value = new Choice(
                new String(),
                new Number(),
                new Text("true"),
                new Text("false"),
                new Text("null"));

            var whitespace = new Many(new Any(" \r\n\t"));
            var separator = new Sequence(whitespace, new Character(','), whitespace);
            var array = new List(value, separator);

            pattern = ...;
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
