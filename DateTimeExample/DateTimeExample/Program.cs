using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Program to pratice using the DateTime object

namespace DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a DateTime object that is a time stamp when the user starts the program
            DateTime now = DateTime.Now;
            
            //prints that time
            Console.WriteLine("The current time is " + now);

            //asks for user input
            Console.WriteLine("please enter a number.");

            //puts user input into a var
            int userInput = Convert.ToInt32(Console.ReadLine());

            //takes user input and adds that number to the date times to show what time it will be that many hours later
            DateTime later = now.AddHours(userInput);
            Console.WriteLine("In {0} hours it will be {1}", userInput, later);


            Console.ReadLine();

        }
    }
}
