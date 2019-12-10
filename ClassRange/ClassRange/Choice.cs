namespace ClassRange
{
    class Choice
    {
        readonly Character singleChar;
        readonly Range givenRange;

        public Choice(params IPattern[] paterns)
        {
        }

        public bool Match(string text)
        {
            return true;
        }
    }
}
