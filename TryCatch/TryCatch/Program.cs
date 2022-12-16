using System;
using System.Collections.Generic;

// Simple app to practice exception handeling

class Program
{
    static void Main(string[] args)
    {
        // try is a clause used to attempt to run a code, and if an exception is found it will go through catch sequences it might have, and then execute the finally clause.
        try
        {
            List<int> intList = new List<int> { 0, 1, 1, 2, 3, 5, 8, 13, 21, 34 };
            Console.WriteLine("Enter a whole number");
            int input = Convert.ToInt32(Console.ReadLine());
            foreach (int item in intList)
            {
                Console.WriteLine(item / input);
            }
        }
        //Catches if the user inputs 0
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex);
        }
        //Catches if the user inputs a string
        catch (FormatException ex)
        {
            Console.WriteLine(ex);
        }
        // Finally always executes.
        finally
        {
            Console.ReadLine();
        }


    }
}

