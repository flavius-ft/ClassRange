﻿namespace ClassRange
{
    class Optional : IPattern
    {
        private readonly IPattern pattern;

        public Optional(IPattern pattern)
        {
            this.pattern = pattern;
        }

        public IMatch Match(string text)
        {
            return new Match(true, pattern.Match(text).RemainingText());
        }
    }
}
