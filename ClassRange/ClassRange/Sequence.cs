using System;

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
            throw new NotImplementedException();
        }
    }
}
