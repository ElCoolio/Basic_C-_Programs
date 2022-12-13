using System;

// This is a simple program that is meant to take in content from the user, do some boolean logic math, and then print the result
// In its current form it sees if the 'applicant' is appoved of insurance

class Program
{
    static void Main()
    {

        //Gets the age, whether they had a DUI, and how many speeding tickets they have
        Console.WriteLine("Enter your age:");
        string appAgeStr = Console.ReadLine();
        int appAge = Convert.ToInt32(appAgeStr);
        Console.WriteLine("Have you ever had a DUI? (enter true or false)");
        string hasDUIStr = Console.ReadLine();
        bool hasDUI = Convert.ToBoolean(hasDUIStr);
        Console.WriteLine("How many speeding tickets do you have?:");
        string spdTckStr = Console.ReadLine();
        int spdTck = Convert.ToInt16(spdTckStr);


        Console.WriteLine("Qualified?");
        //Boolean operations here to check if they are over 15 AND they have 0 DUIs AND the have no more than 3 speeding tickets
        bool isQualified = appAge > 15 && !hasDUI && spdTck <= 3;

        Console.WriteLine(isQualified.ToString());

        Console.ReadLine();

    }
}

