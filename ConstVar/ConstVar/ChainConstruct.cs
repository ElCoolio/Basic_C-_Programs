using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVar
{
    public class ChainConstruct
    {
        // declare vars
        private string name;
        private int number;

        // main constructor, asks for a name and a number
        public ChainConstruct(string name, int number)
        {
            this.name = name;
            this.number = number;
        }
        // chained constructor, only takes in a name, uses original constructor
        public ChainConstruct(string name) : this(name, 10)
        {
            
        }

        //simple writeline method to show constructor vars
        public void myScript()
        {
            Console.WriteLine("It is nice to meet you, {0}, the magic number is {1}",this.name,this.number);
        }

        //simple writeline method to declare a const var
        public void myScript2()
        {
            const string script = ("This next line is using the chain constructor that ignores your number input");
            Console.WriteLine(script);
        }

    }
}
