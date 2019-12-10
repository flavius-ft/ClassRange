namespace ClassRange
{
    class Choice
    {
        readonly Character singleChar;
        readonly Range givenRange;

        public Choice(Character character, Range range)
        {
            this.singleChar = character;
            this.givenRange = range;
        }

        public bool Match(string text)
        {
            return true;
        }
    }
}
