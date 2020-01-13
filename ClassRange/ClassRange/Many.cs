namespace ClassRange
{
    class Many : IPattern
    {
        readonly IPattern pattern;

        public Many(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            if (pattern is Sequence)
            {
                var many = pattern.Match(text);
                return new Match(true, many.RemainingText());
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (!pattern.Match(text[i].ToString()).Success())
                {
                    return new Match(true, text.Substring(i));
                }
            }

            return new Match(true, "");
        }
    }
}
