using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParam
{
    class Program
    {
        static void Main(string[] args)
        {
            // Making an instance of a class
            newClass myNew = new newClass();

            // get input from user
            Console.WriteLine("Please put in an int to cut in half");
            int x = Convert.ToInt32(Console.ReadLine());
            
            // first void method and out param to have the input cut in half and returned.
            myNew.newMethod(x,out int y);

            Console.WriteLine("The number " + x.ToString() + " cut in half is " + y.ToString());

            // Overload method statements.
            MyClass.myOverload(x);
            MyClass.myOverload(out x);
            Console.ReadLine();


        }
    }
}
