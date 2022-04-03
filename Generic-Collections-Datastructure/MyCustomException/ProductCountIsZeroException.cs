using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Datastructure.MyCustomException
{
    public class ProductCountIsZeroException:Exception
    {
        public ProductCountIsZeroException(string message):base(message)
        {

        }


    }
}
