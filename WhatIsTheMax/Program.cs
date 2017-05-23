using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatIsTheMax
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersList = new List<string>();
            Console.WriteLine("Enter a few numbers.");
            string input = Console.ReadLine();
            var numbersList = input.Split(',');
            numbersList.Add(input);

            foreach ( var numbers in numbersList )
            {
                numbersList.Max(number => numbersList);
            }
            
            Console.WriteLine("The largest number entered is " + numbersList.Max() );
            Console.ReadLine();

        }
    }
}

