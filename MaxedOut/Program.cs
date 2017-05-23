using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxedOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of numbers seperated by commas.");
            var input = Console.ReadLine();

            var numbers = input.Split(',');
            var maxNumber = Convert.ToInt32(numbers[0]);


            Console.WriteLine("The largest number entered is " + maxNumber);
            Console.ReadLine();
        }
    }
}
