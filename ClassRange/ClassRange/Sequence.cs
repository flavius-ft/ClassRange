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
            string finalText = string.Empty;
            foreach (var patern in patterns)
                {
                    if (patern.Match(text).Success())
                    {
                    finalText = patern.Match(text).RemainingText();
                    text = text.Substring(1);
                    }
                    else
                    {
                    return new Match(false, copyText);
                    }
            }

            return new Match(true, finalText);
        }
    }
}
