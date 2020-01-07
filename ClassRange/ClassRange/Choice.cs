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
                if (patern.Match(text).Success())
                {
                    return new Match(true, text.Substring(1));
                }
            }

            return new Match(false, text);
        }
    }
}
