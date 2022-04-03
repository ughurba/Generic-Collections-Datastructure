using System;

namespace Generic_Collections_Datastructure.MyCustomException
{
    public class CapacityLimitException : Exception
    {
        public CapacityLimitException(string message) : base(message)
        {

        }
    }
}
