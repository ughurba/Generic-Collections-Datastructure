using System;

namespace Generic_Collections_Datastructure.MyCustomException
{
    public class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message)
        {

        }


    }
}
