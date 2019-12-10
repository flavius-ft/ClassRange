namespace ClassRange
{
    class Character
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
    }
}
