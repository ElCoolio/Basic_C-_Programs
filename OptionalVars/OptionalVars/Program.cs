using System;
using System.Collections.Generic;

// Program praticing optional varibles.

namespace OptionalVars
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionalVar optional = new OptionalVar();
            
            // intro and some varible creation
            Console.WriteLine("Hello, input two numbers.  If you'd like, you can decide to only enter 1, just hit enter with a blank input");
            string xString = Console.ReadLine();
            string yString = Console.ReadLine();
            int x = 0;
            int y = 0;

            // checks if the user enters in nothing for the first value
            if (xString == "" && yString != "")
            {
                Console.WriteLine("Looks like you did not enter anything for the first value.");
            }

            // checks if the user enters in nothing for the second value, set y to 0 as is laid out in the class.
            else if (xString != "" && yString == "")
            {
                Console.WriteLine("Looks like you did not enter anything for the second value.  This method assumes it to be 0 then");
                x = Convert.ToInt32(xString);
                int z = OptionalVar.myMethod(x);
                Console.WriteLine("The method takes the two numbers, adds them, and then divides by 2.  The result in this case is : " + z.ToString());
            }

            // checks if the user enters in nothing for both
            else if (xString == "" && yString == "")
            {
                Console.WriteLine("You didn't enter anything!");
            }
            // this is used if the user enters in both values
            else
            {
                x = Convert.ToInt32(xString);
                y = Convert.ToInt32(yString);
                int z = OptionalVar.myMethod(x, y);
                Console.WriteLine("The method takes the two numbers, adds them, and then divides by 2.  The result in this case is : " + z.ToString());
            }
            Console.ReadLine();


        }
    }
}
