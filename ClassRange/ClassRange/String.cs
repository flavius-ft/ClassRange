namespace ClassRange
{
    class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            var quotationMark = new Character('"');
            var controlChars = new Any("\\\"/bfnrt");
            var charsRange = new Choice(
                new Range(' ', '!'),
                new Range('#', '['),
                new Range(']', '⌂'));
            var chars = new OneOrMore(charsRange);
            var hex = new Choice(
                new Range('0', '9'),
                new Range('a', 'f'),
                new Range('A', 'F'));
            var hexaDigits = new Sequence(
                new Character('u'),
                hex,
                hex,
                hex,
                hex);
            var backSlash = new Sequence(
                new Character('\\'),
                new Optional(controlChars),
                new Optional(hexaDigits));
            var stringChars = new Many(
                new Choice(
                    chars,
                    backSlash));

            pattern = new Sequence(
                quotationMark,
                stringChars,
                quotationMark);
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
