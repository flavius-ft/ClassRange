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
            string copyOfText = text;
            for (int i = 0; i < text.Length; i++)
                {
                var many = pattern.Match(copyOfText);
                if (!many.Success())
                    {
                        return new Match(true, many.RemainingText());
                    }

                copyOfText = many.RemainingText();
                }

            return new Match(true, "");
        }
    }
}
