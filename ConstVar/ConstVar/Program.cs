using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    class Program
    {
        static void Main(string[] args)
        {
            // get input
            Console.WriteLine("Hello there, please enter your name");
            // uses var to make the variable, instead of declaring it a string
            var name = Console.ReadLine();
            Console.WriteLine("Now enter the magic number");
            int num = Convert.ToInt32(Console.ReadLine());

            // makes an object using the main constructor
            ChainConstruct newChain = new ChainConstruct(name, num);
            newChain.myScript();

            // makes a second object using the chained constructor
            var newChain2 = new ChainConstruct(name);
            newChain2.myScript2();
            newChain2.myScript();


            Console.ReadLine();

        }
    }
}
