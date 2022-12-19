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
            Employee test = new Employee() { FirstName = "Sample", LastName = "Student", Id = 1 };
            
            // This uses polymorphism to create an iQuittable object
            iQuittable test2 = new Employee() { FirstName = "Sample", LastName = "Employee", Id = 2 };

            // Uses the superclass method that it inherited from the Person class
            test.SayName();

            // uses the interface class
            test.Quit(test);


            //uses the methods inherited on the iQuittable object

            test2.Quit((Employee)test2);

            Console.ReadLine();



        }
    }
}
