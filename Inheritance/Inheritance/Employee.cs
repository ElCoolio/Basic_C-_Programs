using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee : Person, iQuittable
    {
        public int Id;

        // overrides the SayName class in the parent class
        override public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("ID: " + Id.ToString());
        }

        //implements the interface class
        public void Quit(Employee employee)
        {
            Console.WriteLine(FirstName + " " + LastName + " has quit");
        }

        

    }
}
