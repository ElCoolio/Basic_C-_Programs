using System;
using System.Collections.Generic;

// Simple progrm practising use of lists and arrays.


class Program
{
    static void Main(string[] args)
    {
        // Making the two arrays and the list we will need
        string[] strArray = { "touch", "hearing", "sight", "smell", "taste" };
        int[] intArray = { 1, 2, 3, 5, 7, 11 };
        List<string> strList = new List<string>();
        strList.Add("sweet");
        strList.Add("sour");
        strList.Add("salty");
        strList.Add("bitter");
        strList.Add("savory");


        //Starts program and gets input from user.
        Console.WriteLine("Please enter the index number you are trying to access");
        int index1 = Convert.ToInt32(Console.ReadLine());

        //Checks if the input is in range.
        if (index1 >= 0 && index1 <= 4)
        {
            Console.WriteLine("The content at index " + index1.ToString() + " is " + strArray[index1]);
        }
        else
        {
            Console.WriteLine("That index number does not exist.  Moving on.");
        }


        // The next array
        Console.WriteLine("Please enter the index number you are trying to access");
        int index2 = Convert.ToInt32(Console.ReadLine());

        //Checks if the input is in range.
        if (index2 >= 0 && index2 <= 5)
        {
            Console.WriteLine("The content at index " + index2.ToString() + " is " + intArray[index2]);
        }
        else
        {
            Console.WriteLine("That index number does not exist.  Moving on.");
        }


        // The list
        Console.WriteLine("Please enter the index number you are trying to access");
        int index3 = Convert.ToInt32(Console.ReadLine());

        //Checks if the input is in range.
        if (index3 >= 0 && index3 <= 4)
        {
            Console.WriteLine("The content at index " + index3.ToString() + " is " + strList[index3]);
        }
        else
        {
            Console.WriteLine("That index number does not exist.  Goodbye");
        }

        Console.ReadLine();
    }
}

