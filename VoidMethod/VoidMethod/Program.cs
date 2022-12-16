using System;
using System.Collections.Generic;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            VoidMethod myVoid = new VoidMethod();
            int x = 5;
            int y = 7;

            // using a void method we will post int y to the screen.  There is a math operation that happens to x, but it isn't returned.
            Console.WriteLine("We will be using a void method to send some content to the console");
            VoidMethod.myMethod(x, y);
            Console.ReadLine();

        }
    }
}
