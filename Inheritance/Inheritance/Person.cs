using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person
    {

        public string FirstName;
        public string LastName;

        // makes a class that is set up to be overwritten by the child classes.
        public abstract void SayName();

    }
}
