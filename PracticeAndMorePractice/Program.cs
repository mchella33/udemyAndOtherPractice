using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeAndMorePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number.");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(x, m));
            Console.ReadLine();
        }
    }
}
