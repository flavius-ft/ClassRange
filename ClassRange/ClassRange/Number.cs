namespace ClassRange
{
    class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            var minus = new Character('-');
            var zero = new Character('0');

            var digit = new Range('0', '9');
            var digits = new OneOrMore(digit);
            var point = new Sequence(new Character('.'), digits);
            var natural = new Choice(
                zero,
                digits);
            var integer = new Sequence(
                new Optional(minus),
                natural);
            var exponent = new Sequence(
                new Any("eE"),
                new Optional(new Any("+-")),
                digits);
            var fractional = new Sequence(
                point,
                new Optional(exponent));

            pattern = new Sequence(
                integer,
                new Optional(fractional),
                new Optional(exponent));
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
