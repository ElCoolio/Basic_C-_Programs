using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Hello, let's math it up.  Please enter a number");
            int userNum = Convert.ToInt32(Console.ReadLine());

            MyMath math = new MyMath();


            Console.WriteLine("Let's add five to your number, " + userNum);
            userNum = math.myAdd(userNum);
            Console.WriteLine("Now the number is " + userNum);


            Console.WriteLine("Let's subtract 2 to that new number, " + userNum);
            userNum = math.mySub(userNum);
            Console.WriteLine("Now the number is " + userNum);

            Console.WriteLine("Let's multiply 3 to that new number, " + userNum);
            userNum = math.myMultiply(userNum);
            Console.WriteLine("Now the number is " + userNum);

            Console.WriteLine("Isn't math cool?");
            Console.ReadLine();

        }
    }
}
