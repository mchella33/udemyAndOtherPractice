using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsDoThis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number");
            int s = Convert.ToInt32(Console.ReadLine());

            int maxValue;

            maxValue = (n > s) ? n : s;

            Console.WriteLine("The largest number entered is " + maxValue);
            Console.ReadLine();
        }
    }
}