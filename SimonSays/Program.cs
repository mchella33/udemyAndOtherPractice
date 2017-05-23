using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimonSays
{
    class Program
    {
        static void Main(string[] args)
        {
            var totalInput = 0;

            while (true)
            {
                Console.WriteLine("Enter any number to continue or enter 'ok' to exit.");
                var input = Console.ReadLine();


                if (input.ToLower() == "ok")
                    break;


                totalInput += Convert.ToInt32(input);

            }
            Console.WriteLine("The total of numbers entered is " + totalInput);
            Console.ReadLine();
        }
        //{
        //    var sum = 0;
        //    while (true)
        //    {
        //        Console.Write("Enter a number (or 'ok' to exit): ");
        //        var input = Console.ReadLine();

        //        if (input.ToLower() == "ok")
        //            break;

        //        sum += Convert.ToInt32(input);
        //    }
        //    Console.WriteLine("Sum of all numbers is: " + sum);
        //    Console.ReadLine();
        //}
    }
    }

