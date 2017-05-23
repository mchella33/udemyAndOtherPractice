using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItIsWhatItIs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number.");
            int input = Convert.ToInt32(Console.ReadLine());

            var factorial = 1;
            for(int i = 1; i<= input; i++)
            {
                factorial = input * i;
                Console.WriteLine("The factorial of the number entered is " + factorial);
                Console.ReadLine();
            }
        }
    }
}
