using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeYouSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int x = Convert.ToInt32(Console.ReadLine());

            if (n > x)
            {
                Console.WriteLine(n);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(x);
                Console.ReadLine();
            }

        }
    }
}
