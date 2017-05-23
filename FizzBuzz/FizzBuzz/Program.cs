using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    Console.ReadLine();

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                //Console.WriteLine(" ");
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
