using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStuffAndThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10.");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid");
                Console.ReadLine();
            }
        }
    }
}
