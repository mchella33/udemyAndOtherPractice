using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubtIt
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter any number or enter 'ok' to exit.");
                var input = Console.ReadLine();
                sum += Convert.ToInt32(input);

                if (input == "ok")
                {
                    Console.WriteLine("You entered 'ok' and broke out of the loop.");
                    Console.Read();
                }
                Console.WriteLine("The total of the numbers entered is " + sum);
            }
        }
    }
}
