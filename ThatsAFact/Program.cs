using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsAFact
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;

                sum += Convert.ToInt32(input);
            }
            Console.WriteLine("Sum of all numbers is: " + sum);
            Console.ReadLine();
            //var n = 0;
            //double total = 0;

            //while (true)
            //{
            //    if (n.ToString() != "ok")
            //    {
            //        Console.WriteLine("Enter a number or hit 'ok' to exit.");
            //        n = Convert.ToInt32(Console.ReadLine());

            //        List<double> allNumbers = new List<double>();
            //        foreach (double number in allNumbers)

            //        allNumbers.Add(number);
            //        total = allNumbers.Sum();


            //    }
            //    Console.WriteLine("The total of all the numbers entered is " + total);
            //    Console.ReadLine();

            //    if (n.ToString() == "ok")
            //        break;

            //}
            //Console.WriteLine("You hit 'ok' and exited the program.");
            //Console.ReadLine();

        }
        
    }
}
