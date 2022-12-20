using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Try block
            try
            {
                // asks for input for user
                Console.WriteLine("enter the day of the week");
                string dayinput = Console.ReadLine();

                // parses the input to check if it is part of the enum DaysOfTheWeek
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                Console.WriteLine("The value of that day of the week is " + Convert.ToInt32(day));
            }
            //catches any error
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
        }

        //enum days of the week.
       public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
 
}
