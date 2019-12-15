namespace ClassRange
{
    interface IMatch
    {
        bool Success();

        string RemainingText(string text);
    }
}
