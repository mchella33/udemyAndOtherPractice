using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number.");
            int input = Convert.ToInt32(Console.ReadLine());

            int factorial = 1;
            for (int i = 1; i <= input; i++)
            {
                factorial *= i;


            }
            Console.WriteLine(factorial);
            Console.ReadLine();
        }       
    }
}
