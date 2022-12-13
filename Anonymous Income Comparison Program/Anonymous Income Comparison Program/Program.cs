using System;

// This is a simple program that is meant to take in content from the user, do some computations, and then send write data back in the console.
// In its current form it compares salaries of two individuals

class Program
{
    static void Main()
    {

        //Prints intro of program in console
        Console.WriteLine("Anonymous Income Comparison Program");

        //Gets the Hourly rate and Hours worked per week for the first person
        Console.WriteLine("Enter in Person 1 Hourly rate as a number");
        string p1hrString = Console.ReadLine();
        decimal p1hr = Convert.ToDecimal(p1hrString);
        Console.WriteLine("Enter in Person 1 hours worked per week");
        string p1hwString = Console.ReadLine();
        decimal p1hw = Convert.ToDecimal(p1hwString);


        //Gets the Hourly rate and Hours worked per week for the second person
        Console.WriteLine("Enter in Person 2 Hourly rate as a number");
        string p2hrString = Console.ReadLine();
        decimal p2hr = Convert.ToDecimal(p2hrString);
        Console.WriteLine("Enter in Person 2 hours worked per week");
        string p2hwString = Console.ReadLine();
        decimal p2hw = Convert.ToDecimal(p2hwString);

        //Prints the annual salary of each person
        decimal p1as = p1hr * p1hw * 52;
        decimal p2as = p2hr * p2hw * 52;
        Console.WriteLine("Annual salary of Person 1: ");
        Console.WriteLine(p1as.ToString());
        Console.WriteLine("Annual salary of Person 2: ");
        Console.WriteLine(p2as.ToString());

        // compares the two salaries and confirms who makes more
        bool isgreater = p1as > p2as;
        Console.WriteLine("Does person 1 make more money than person 2?");
        Console.WriteLine(isgreater.ToString());

        //Used to keep window open
        Console.ReadLine();

    }
}

