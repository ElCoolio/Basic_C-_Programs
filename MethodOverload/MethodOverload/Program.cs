using System;
using System.Collections.Generic;

// In this program we will make a class with method with the same name, but act differently if they are given different data types

namespace MethodOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            myMethod method = new myMethod();

            Console.WriteLine("Hello, we are going to do some math operations on a number");

            //  This is the first method we made, which takes an int and passes an int
            Console.WriteLine("First, we are going pass an int and add 5");
            int x1 = 5;
            int y1 = myMethod.doMath(x1);
            Console.WriteLine(y1.ToString());

            //  This is the second method, which takes a decimal and passes it out as an int
            Console.WriteLine("Next, we are going pass a decimal and multiply it by 5, returning it as an int");
            decimal x2 = 5.32m;
            int y2 = myMethod.doMath(x2);
            Console.WriteLine(y2.ToString());

            //  This is the third method, which takes a string and passes it out as an int.
            Console.WriteLine("Finally, we are going to pass a string value and subtract 2");
            string x3 = "3";
            int y3 = myMethod.doMath(x3);
            Console.WriteLine(y3.ToString());
            Console.ReadLine();

        }
    }
}
