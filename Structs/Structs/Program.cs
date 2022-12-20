using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employees = new List<Employees>();

            Employees employees1 = new Employees() { FirstName = "Joe", LastName = "McClorey", Id = 1 };
            Employees employees2 = new Employees() { FirstName = "Stephen", LastName = "Brinkman", Id = 2 };
            Employees employees3 = new Employees() { FirstName = "Casey", LastName = "Bramer", Id = 3 };
            Employees employees4 = new Employees() { FirstName = "Alex", LastName = "Carter", Id = 4 };
            Employees employees5 = new Employees() { FirstName = "Joe", LastName = "Schnieder", Id = 5 };
            Employees employees6 = new Employees() { FirstName = "Mary", LastName = "Pfieffer", Id = 6 };
            Employees employees7 = new Employees() { FirstName = "Elese", LastName = "Boylson", Id = 7 };
            Employees employees8 = new Employees() { FirstName = "Ann", LastName = "Boylson", Id = 8 };
            Employees employees9 = new Employees() { FirstName = "Linda", LastName = "Boylson", Id = 9 };
            Employees employees10 = new Employees() { FirstName = "David", LastName = "Coondit", Id = 10 };

            employees.Add(employees1);
            employees.Add(employees2);
            employees.Add(employees3);
            employees.Add(employees4);
            employees.Add(employees5);
            employees.Add(employees6);
            employees.Add(employees7);
            employees.Add(employees8);
            employees.Add(employees9);
            employees.Add(employees10);

            foreach (Employees person in employees)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.Id);
            }

            Console.ReadLine();




        }
    }
}
