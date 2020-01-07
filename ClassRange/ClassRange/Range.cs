using System;

namespace ClassRange
{
    public class Range : IPattern
    {
        private readonly char start;
        private readonly char end;

        public Range(char startText, char endText)
        {
            this.start = startText;
            this.end = endText;
        }

        IMatch IPattern.Match(string text)
        {
            return !string.IsNullOrEmpty(text) && text[0] >= start && text[0] <= end ?
                   new Match(true, text.Substring(1)) : new Match(false, text);
        }
    }
}
