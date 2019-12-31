using System;

namespace ClassRange
{
    class Character : IPattern
    {
        readonly char pattern;

        public Character(char pattern)
        {
            this.pattern = pattern;
        }

        public bool Match(string text)
        {
            return !string.IsNullOrEmpty(text) && text[0] == pattern;
        }

        IMatch IPattern.Match(string text)
        {
            throw new NotImplementedException();
        }
    }
}
