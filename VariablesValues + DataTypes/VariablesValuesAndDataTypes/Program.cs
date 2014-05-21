using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesValuesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
           // Order of operations - arithmatic operators..
            double result = 5 + 6 * 4 + 1;
            //              |   |   |   |
            //              |   \   /   |
            //              |    ---    |
            //              |     |     |
            //              \     /     |
            //               \   /      |
            //                ---       |
            //                 |        |
            //                 \        /
            //                  \      /
            //                    ----
            Console.WriteLine("the result of the math is " + result);

            // What does casting -really- do??
            char singleDigit = '5';
            int simpleNumber = 25;
            //The result of casting...
            Console.WriteLine("Casting '5' ...");
            Console.WriteLine((int)singleDigit);
            Console.WriteLine("Casting 25 ...");
            Console.WriteLine((double)simpleNumber);

            // The result of converting...
            Console.WriteLine("converting '5' ...");
            Console.WriteLine(Convert.ToInt32(singleDigit));
            Console.WriteLine("Converting 25 ...");
                Console.WriteLine(Convert.ToDouble(simpleNumber));
            //"a;ternate" way of converting using the Parse method
                Console.WriteLine("Converting '5' using int. parse()");
            // Console.writeLine(int. Parse(SingleDigit)); // can't "parse" a single char
                Console.WriteLine(int.Parse(singleDigit.ToString())); //can parse a string...
                Console.WriteLine("The value in the variables singleDigit is " +
           singleDigit.ToString());
                Console.WriteLine("converting '5' after calling . ToString()...");
                Console.WriteLine(Convert.ToInt32(singleDigit.ToString()));




















            







        }
    }
}
