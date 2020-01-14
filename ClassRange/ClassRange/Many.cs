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
            IMatch many = new Match(true, text);

            while (many.Success())
            {
                many = pattern.Match(many.RemainingText());
            }

            return new Match(true, many.RemainingText());
        }
    }
}
