namespace ClassRange
{
    class Number : IPattern
    {
        private readonly IPattern pattern;

        public Number()
        {
            pattern = new Range('0', '9');
        }

        public IMatch Match(string text)
        {
            return pattern.Match(text);
        }
    }
}
