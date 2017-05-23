using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The largest number entered is " + Math.Max(x, s));
            Console.ReadLine();
        }
    }
}
