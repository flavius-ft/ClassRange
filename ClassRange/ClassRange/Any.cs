namespace ClassRange
{
    class Any : IPattern
    {
        readonly string accepted;

        public Any(string accepted)
        {
            this.accepted = accepted;
        }

        public IMatch Match(string text)
        {
            return accepted.Contains(text[0]) ? new Match(true, text.Substring(1)) : new Match(false, text);
        }
    }
}
