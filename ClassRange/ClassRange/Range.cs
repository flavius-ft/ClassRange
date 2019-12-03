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
            return IsTextInRange(start, end, text);
        }

        internal bool IsTextInRange(char start, char end, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (!IsInRange(start, end, text[i]))
                {
                    return false;
                }
            }

            return true;
        }

        internal bool IsInRange(char start, char end, char text)
        {
            return Convert.ToChar(text) >= start && Convert.ToChar(text) <= end;
        }
    }
}
