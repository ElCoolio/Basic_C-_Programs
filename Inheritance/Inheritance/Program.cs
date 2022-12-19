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
            Employee<string> test = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 1 };

            // adds the the generic string list we created for test
            test.things.Add("This");
            test.things.Add("is");
            test.things.Add("a");
            test.things.Add("list");
            test.things.Add("of");
            test.things.Add("strings");
            



            // Creates an identical object to test the operator overides.
            Employee<int> test3 = new Employee<int>() { FirstName = "Sample", LastName = "Student", Id = 1 };

            test3.things.Add(1);
            test3.things.Add(2);
            test3.things.Add(3);
            test3.things.Add(4);
            test3.things.Add(5);


            // This uses polymorphism to create an iQuittable object
            //iQuittable test2 = new Employee() { FirstName = "Sample", LastName = "Employee", Id = 2 };

            // Uses the superclass method that it inherited from the Person class
            //test.SayName();

            // uses the interface class
            //test.Quit(test);


            //uses the methods inherited on the iQuittable object

            //test2.Quit((Employee)test2);

            //Comparison opertator overrides
            //Console.WriteLine((Employee)test2 == test);
            //Console.WriteLine((Employee)test == test3);

            // foreach loop to print the list items
            foreach( int things in test3.things)
            {
                Console.WriteLine(things.ToString());
            }

            foreach (string things in test.things)
            {
                Console.WriteLine(things.ToString());
            }


            Console.ReadLine();





        }
    }
}
