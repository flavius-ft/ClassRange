using System;

namespace ClassRange
{
    class Choice : IPattern
    {
        private IPattern[] patterns;

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

        internal void Add(IPattern pattern)
        {
            Array.Resize(ref patterns, patterns.Length + 1);
            patterns[patterns.Length - 1] = pattern;
        }
    }
}
