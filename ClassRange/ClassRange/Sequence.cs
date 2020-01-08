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
            string copyText = text;
            foreach (var patern in patterns)
                {
                    if (patern.Match(text).Success())
                    {
                    text = patern.Match(text).RemainingText();
                    }
                    else
                    {
                    return new Match(false, copyText);
                    }
            }

            return new Match(true, text);
        }
    }
}
