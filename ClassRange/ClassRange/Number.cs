namespace ClassRange
{
    class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var digits = new OneOrMore(new Range('1', '9'));
            var exponent = new Sequence(digits, new Any("eE"), new Optional(new Any("+-")), digits);
            var initialNumberZero = new Sequence(new Choice(new Character('0'), digits), new Character('.'), exponent);
            pattern = new Sequence(new Optional(new Character('-')), new Choice(initialNumberZero, digits));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
