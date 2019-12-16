namespace ClassRange
{
    class Match : IMatch
    {
        public string RemainingText(string text)
        {
            return text.Substring(1);
        }

        public bool Success(Character c, string text)
        {
            return text[0].Equals(c);
        }
    }
}
