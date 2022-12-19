using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates the employee object, and give the values that it inherited from the Person Class
            Employee test = new Employee() { FirstName = "Sample" , LastName = "Student" };


            // Uses the superclass method that it inherited from the Person class
            test.SayName();

            Console.ReadLine();



        }
    }
}
