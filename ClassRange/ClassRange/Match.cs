namespace ClassRange
{
    class Match : IMatch
    {
        public string RemainingText(string text)
        {
            return text.Substring(1);
        }

        public bool Success()
        {
            throw new System.NotImplementedException();
        }
    }
}
