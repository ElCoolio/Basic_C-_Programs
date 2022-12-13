using System;

// This is a simple program that is meant to take in content from the user and does some simple math to it
class Program
{
    static void Main()
    {

        //gets the intial value from the user
        //then multiplies it by 50
        Console.WriteLine("Please enter in a number:");
        string stringNum = Console.ReadLine();
        decimal decNum = Convert.ToDecimal(stringNum);
        decimal decTimesFifty = decNum * 50;
        Console.WriteLine(decTimesFifty.ToString());

        //gets the intial value from the user
        //then adds 25 to it
        Console.WriteLine("Please enter in a number:");
        string stringNum2 = Console.ReadLine();
        decimal decNum2 = Convert.ToDecimal(stringNum2);
        decimal decPlusTwentyFive = decNum2 + 25;
        Console.WriteLine(decPlusTwentyFive.ToString());

        //gets the intial value from the user
        //then divides it by 12.5
        Console.WriteLine("Please enter in a number:");
        string stringNum3 = Console.ReadLine();
        decimal decNum3 = Convert.ToDecimal(stringNum3);
        decimal decDivideTwelve = decNum3 / 12.5m;
        Console.WriteLine(decDivideTwelve.ToString());

        //gets the intial value from the user
        //checks if the number is greater than 50
        Console.WriteLine("Please enter in a number:");
        string stringNum4 = Console.ReadLine();
        decimal decNum4 = Convert.ToDecimal(stringNum4);
        bool greaterThanFifty = decNum4 > 50;
        Console.WriteLine(greaterThanFifty.ToString());

        //gets the intial value from the use
        //then prints the remainder to the console
        Console.WriteLine("Please enter in a number:");
        string stringNum5 = Console.ReadLine();
        decimal decNum5 = Convert.ToDecimal(stringNum5);
        decimal decRemainder = decNum5 % 7;
        Console.WriteLine(decRemainder.ToString());

        Console.Read();


    }
}

