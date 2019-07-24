using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainLogic
{
    public class SomeClass
    {
        public static int Add(int a, int b)
        {
            if(a < 5)
            {
                return b;
            }
            return a + b;
        }
    }
}
