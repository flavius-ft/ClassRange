namespace ClassRange
{
    class Match : IMatch
    {
        private readonly bool success;
        private readonly string remainingText;

        public Match(bool success, string remainingText)
        {
            this.success = success;
            this.remainingText = remainingText;
        }

        public string RemainingText()
        {
            return remainingText;
        }

        public bool Success()
        {
            return success;
        }
    }
}
