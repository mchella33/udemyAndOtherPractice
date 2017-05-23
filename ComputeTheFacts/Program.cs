using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputeTheFacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;


            for (int i = 1; i <= n; i--)
            {
                factorial = (factorial * n);
                Console.WriteLine("The factorial of the number you entered is {0} ", + factorial);
                Console.ReadLine();
            }




        }
    }
}
