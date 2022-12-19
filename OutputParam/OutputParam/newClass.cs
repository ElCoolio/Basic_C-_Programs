using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParam
{
    class newClass
    {
        // This is the first void method that takes an input, divides it in 2, and returns the int.  It is a void method, but can return an int through the out param
        public void newMethod(int x, out int y)
        {
            y = x / 2;
        }


    }
}
