using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee : Person
    {
        public int Id;

        // overrides the SayName class in the parent class
        override public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("ID: " + Id.ToString());
        }

    }
}
