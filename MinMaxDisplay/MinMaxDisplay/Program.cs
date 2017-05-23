using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxDisplay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Math.Max(input1, input2));
            Console.ReadLine();

           
            

            
        }
    }
}
