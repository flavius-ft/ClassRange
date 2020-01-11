namespace ClassRange
{
    class Text : IPattern
    {
        readonly string prefix;

        public Text(string prefix)
        {
            this.prefix = prefix;
        }

        public IMatch Match(string text)
        {
            return text.StartsWith(prefix) ? new Match(true, text.Substring(prefix.Length))
                    : new Match(false, text);
        }
    }
}
