namespace ClassRange
{
    class Many : IPattern
    {
        private readonly IPattern pattern;

        public Many(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            while (pattern.Match(text).Success())
                {
                text = pattern.Match(text).RemainingText();
                }

            return new Match(true, text);
        }
    }
}
