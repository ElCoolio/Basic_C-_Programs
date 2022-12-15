using System;

// This is a simple program that is meant to take in content from the user, do some computations, and then send write data back in the console.
// In its current form it generates shipping quotes for a package

class Program
{
    static void Main()
    {

        //Prints intro of program in console
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        //Gets the weight as an int, if too heavy the program ends.
        Console.WriteLine("Please enter the weight of your package:");
        string weightString = Console.ReadLine();
        int weight = Convert.ToInt16(weightString);
        //checks if weight is greater and end the program if it is
        if (weight > 50) 
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            Console.ReadLine();
        }
        else
        {
            // gets dimensions of the package
            Console.WriteLine("Please enter the width of the package");
            string widthString = Console.ReadLine();
            Console.WriteLine("Please enter the height of the package");
            string heightString = Console.ReadLine();
            Console.WriteLine("Please enter the length of the package");
            string lengthString = Console.ReadLine();
            // converts the input to int
            int height = Convert.ToInt16(heightString);
            int width = Convert.ToInt16(widthString);
            int length = Convert.ToInt16(lengthString);
            int total = height + width + length;

            // branching statement if the package is too large.
            if (total > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");

            }
            else
            {
                // computes the quote using the dimensions
                int packageSize = height * width * length;
                int packageSizeAndWeight = packageSize * weight;
                decimal quote = packageSizeAndWeight / 100;

                //Displays the quote and ends the program
                Console.WriteLine("Your estimated total for shipping this package is: " + quote.ToString("C"));
                Console.WriteLine("Thank you");
                
            }

            
            Console.ReadLine();

        }

    }
}
