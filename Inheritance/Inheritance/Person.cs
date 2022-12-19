using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Person
    {

        public string FirstName;
        public string LastName;

        // makes a class that is set up to be overwritten by the child classes.
        virtual public void  SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}
