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
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            return text[0] >= start && text[0] <= end;
        }
    }
}
