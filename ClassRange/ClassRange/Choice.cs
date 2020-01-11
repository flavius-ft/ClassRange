namespace ClassRange
{
    class Choice : IPattern
    {
        private readonly IPattern[] patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            foreach (var patern in patterns)
            {
                var match = patern.Match(text);

                if (match.Success())
                {
                    return new Match(true, match.RemainingText());
                }
            }

            return new Match(false, text);
        }
    }
}
