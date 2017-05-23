using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            var input = Convert.ToInt32(Console.ReadLine());

            int factorial = input*(input);
            Console.WriteLine("The number you entered was " + input + " and it's factorial is " + factorial);
            Console.ReadLine();

        }
    }
}
