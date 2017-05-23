using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactOrFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var finalTotal = 1;


            Console.WriteLine("Enter any number");
            var number = Console.Read();

            for (int i = 1; i <= number; i++)
            {
                finalTotal = number * i;
                Console.WriteLine();
            }
            Console.WriteLine("The factorial of the number you entered is " + finalTotal);
            Console.ReadLine();
        }
    }
}
