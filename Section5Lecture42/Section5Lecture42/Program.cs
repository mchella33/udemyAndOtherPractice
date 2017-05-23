using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section5Lecture42    
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter a number between 1 and 10");
            //var input = Console.ReadLine();
            //var number = Convert.ToInt32(input);

            //if (number >= 1 && number <= 10)
            //{
            //    Console.WriteLine("Valid");
            //    Console.ReadLine();
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //    Console.ReadLine();
            //}

            Console.WriteLine("Enter any number between 1-10");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);

            if (number>=1 && number <= 10)
            {
                Console.WriteLine("Valid");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("InValid");
                Console.ReadLine();
            }

        }
    }
}
