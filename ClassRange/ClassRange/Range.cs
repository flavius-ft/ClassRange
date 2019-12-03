using System;

namespace ClassRange
{
    public class Range
    {
        private readonly char start;
        private readonly char end;

        public Range(char startText, char endText)
        {
            this.start = startText;
            this.end = endText;
        }

        public bool Match(string text)
        {
            return IsInRange(start, end, text);
        }

        private bool IsInRange(char start, char end, string text)
        {
            return Convert.ToChar(text) >= start && Convert.ToChar(text) <= end;
        }
    }
}
