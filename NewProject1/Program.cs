using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number between 1 and 10.");
            int x = Convert.ToInt32(Console.ReadLine());

            if (x >= 1 && x <= 10)
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
