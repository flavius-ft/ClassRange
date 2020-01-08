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
                    if (!patern.Match(text).Success())
                    {
                    return new Match(false, copyText);
                    }

                    text = text.Substring(1);
            }

            return new Match(true, text);
        }
    }
}
