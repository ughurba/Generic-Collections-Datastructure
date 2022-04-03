namespace Generic_Collections_Datastructure
{
    static class BookLimitExten
    {
        public static bool Limit(this int str, int book, int limit)
        {
            if (book <= limit)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
