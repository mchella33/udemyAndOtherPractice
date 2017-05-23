using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SusieSays
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumbers = 0;

            for (int i = 1; i <= 100; i++)
                if (i % 3 == 0)
                    totalNumbers++;
            Console.WriteLine("The total number of numbers divisible by 3 are " + totalNumbers);
            Console.ReadLine();
        }
    }
}
