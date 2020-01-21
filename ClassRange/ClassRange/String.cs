namespace ClassRange
{
    class String : IPattern
    {
        private readonly IPattern pattern;

        public String()
        {
            var quotationMark = new Character('"');
            var controlChars = new Any("\\\"/bfnrt");
            var validChar = new Choice(
                new Range(' ', '!'),
                new Range('#', '['),
                new Range(']', (char)ushort.MaxValue));
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
            var escapeChars = new Sequence(
                new Character('\\'),
                new Choice(
                new Optional(controlChars),
                new Optional(hexaDigits)));
            var jsonChar = new Choice(
                validChar,
                escapeChars);
            var stringChars = new Many(jsonChar);
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
