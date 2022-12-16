using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    class myMethod
    {


        // int to int operation
        public static int doMath(int x)
        {
            x = x + 5;
            return x;
        }

        // decimal to int operation
        public static int doMath(decimal x)
        {
            x = x * 3;
            return Convert.ToInt32(x);
        }


        // string to int operation
        public static int doMath(string x)
        {
            int intX = Convert.ToInt32(x);
            intX = intX - 2;
            return intX;
        }

    }
}
