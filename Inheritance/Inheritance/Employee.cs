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

        // overloads the != and == operator so we can compare employees by ID
        public static bool operator== (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // operator overides that compare employees on their ids, == and != have to be done in pairs.
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
