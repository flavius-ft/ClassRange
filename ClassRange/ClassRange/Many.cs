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
                foreach (char singleChar in text)
                {
                var many = pattern.Match(text);
                if (!many.Success())
                    {
                        return new Match(true, many.RemainingText());
                    }

                text = many.RemainingText();
                }

                return new Match(true, "");
        }
    }
}
