﻿namespace ClassRange
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
            foreach (var patern in patterns)
            {
                if (patern.Match(text).Success())
                {
                   text = new Match(true, text.Substring(1)).RemainingText();
                }
                else
                {
                    return new Match(false, text);
                }
            }

            return new Match(true, text);
        }
    }
}
