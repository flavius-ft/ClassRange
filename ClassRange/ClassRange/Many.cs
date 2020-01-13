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
            bool manyCondition = true;

            while (manyCondition)
                {
                var many = pattern.Match(text);
                manyCondition = many.Success();
                text = many.RemainingText();
                }

            return new Match(true, text);
        }
    }
}
