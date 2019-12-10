namespace ClassRange
{
    class Choice
    {
        readonly IPattern[] patterns;

        public Choice(params IPattern[] patterns)
        {
            this.patterns = patterns;
        }

        public bool Match(string text)
        {
            foreach (var patern in patterns)
            {
                if (patern.Match(text))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
