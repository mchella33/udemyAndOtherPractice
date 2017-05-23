using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecutives
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphens.");
            var input = Console.ReadLine();
            input.Split('-');

            int[] numbersList = new int[] { };
            

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Enter a string of numbers separated by hyphens.");
                Console.ReadLine();
            }
            else if (input != null)
            {
                Console.WriteLine("The numbers you listed are : " + numbersList.ToList());
                Console.ReadLine();
            }
            


        }
    }
}
