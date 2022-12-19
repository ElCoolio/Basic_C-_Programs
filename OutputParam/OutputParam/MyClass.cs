using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParam
{
    // We made the class static, which means we don't have to create an instance of the class to call upon the methods.
    public static class MyClass
    {


        // This first class just takes an int and returns text.
        public static void myOverload(int x)
        {
            Console.WriteLine("This is the original method that takes in the int x: " + x.ToString());
        }


        // This overloaded method doesn't take any params, but sends one out.
        public static void myOverload(out int x)
        {
            x = 17;
            Console.WriteLine("This is the overloaded method with the out param: " + x.ToString());
        }

    }
}
