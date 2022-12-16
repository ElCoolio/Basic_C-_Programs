using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalVars
{
    class OptionalVar
    {
        //Class with optional value y,  takes the two values, adds them together, and divides by 0.  y is an optional value.
        public static int myMethod(int x, int y = 0) { 

        int z = ((x + y) / 2);
        return z;
        }

    }
}
