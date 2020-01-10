namespace ClassRange
{
    class Sequence : IPattern
    {
        private readonly IPattern[] patterns;

        public Sequence(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public IMatch Match(string text)
        {
            IMatch match = new Match(true, text);

            foreach (var patern in patterns)
            {
                match = patern.Match(match.RemainingText());

                if (!match.Success())
                {
                    return new Match(false, text);
                }
            }

            return match;
        }
    }
}
