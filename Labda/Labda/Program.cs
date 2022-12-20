using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labda
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates list
            List<Employee> employees = new List<Employee>();

            // creates 
            Employee employee1 = new Employee() { FirstName = "Joe", LastName = "McClorey", Id = 1 };
            Employee employee2 = new Employee() { FirstName = "Stephen", LastName = "Brinkman", Id = 2 };
            Employee employee3 = new Employee() { FirstName = "Casey", LastName = "Bramer", Id = 3 };
            Employee employee4 = new Employee() { FirstName = "Alex", LastName = "Carter", Id = 4 };
            Employee employee5 = new Employee() { FirstName = "Joe", LastName = "Schnieder", Id = 5 };
            Employee employee6 = new Employee() { FirstName = "Mary", LastName = "Pfieffer", Id = 6 };
            Employee employee7 = new Employee() { FirstName = "Elese", LastName = "Boylson", Id = 7 };
            Employee employee8 = new Employee() { FirstName = "Ann", LastName = "Boylson", Id = 8 };
            Employee employee9 = new Employee() { FirstName = "Linda", LastName = "Boylson", Id = 9 };
            Employee employee10 = new Employee() { FirstName = "David", LastName = "Coondit", Id = 10 };

            // adds the Employee I created
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            // first loop just prints the entire list to ensure I have it in right
            foreach (Employee person in employees)
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.Id);
            }

            // creates list for list of employees with the first name of Joe
            List<Employee> joeList = new List<Employee>();
            //this foreach loop creates a new list of all employees with the first name "Joe"
            Console.WriteLine("\nThis is the list of employees whose first name is Joe.");
            foreach (Employee person in employees)
            {
                if (person.FirstName == "Joe")
                {
                    Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.Id);
                    joeList.Add(person);
                }
            }
            


            Console.WriteLine("\nThis is the list of employees whose first name is Joe.  This time with a Lamda expression");
            List<Employee> joeLambda = new List<Employee>();
            // This is a lambda expression with the same parameters
            foreach (Employee person in employees.FindAll(e => e.FirstName == "Joe"))
            {
                Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.Id);
                joeLambda.Add(person);
            }


            Console.WriteLine("\nThis is the list of employees whose ID is greater than five");
            List<Employee> idGrtFive = new List<Employee>();
            foreach (Employee person in employees.FindAll(e => e.Id > 5))
            {           
                Console.WriteLine(person.FirstName + " " + person.LastName + " ID: " + person.Id);
                idGrtFive.Add(person);           
            }
            Console.ReadLine();

        }
    }
}
