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
            var array = new Sequence(
                new Character('['),
                new List(new Sequence(whitespace, value), new Character(',')),
                new Character(']'));

            value.Add(array);

            var element = new Sequence(
                    whitespace,
                    new String(),
                    whitespace,
                    new Character(':'),
                    whitespace,
                    value);
            var objectValue = new Sequence(
                new Character('{'),
                new List(new Sequence(whitespace, element), new Character(',')),
                new Character('}'));

            value.Add(objectValue);

            pattern = value;
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
