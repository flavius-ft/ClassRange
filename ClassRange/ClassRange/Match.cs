using System;

namespace ClassRange
{
    class Match : IMatch
    {
        private readonly IPattern patern;
        private readonly string text;

        public Match(IPattern patern, string text)
        {
            this.patern = patern;
            this.text = text;
        }

        public Match(string text)
        {
            this.text = text;
        }

        public string RemainingText()
        {
            return text.Substring(1);
        }

        public bool Success()
        {
            throw new NotImplementedException();
        }
    }
}
