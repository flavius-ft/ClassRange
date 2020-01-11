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
            return text?.Substring(0, prefix.Length).Equals(prefix) == true ? new Match(true, text.Substring(prefix.Length))
                    : new Match(false, text);
        }
    }
}
