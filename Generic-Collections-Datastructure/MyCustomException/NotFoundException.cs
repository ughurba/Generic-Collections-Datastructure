using System;

namespace Generic_Collections_Datastructure.MyCustomException
{
    public class NotFoundException : Exception

    {
        public NotFoundException(string message) : base(message)
        {

        }
    }
}
