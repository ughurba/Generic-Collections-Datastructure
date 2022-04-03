using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections_Datastructure
{
    static class BookLimitExten
    {
        public static bool Limit(this int str, int book,int limit)
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
