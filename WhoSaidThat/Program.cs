using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhoSaidThat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random number = new Random();
            int secretNumber = number.Next(1, 10);
            Console.WriteLine("Enter a guess. The secret number is " + secretNumber);
            int guess = Convert.ToInt32(Console.ReadLine());

            if (guess == secretNumber)
            {
                Console.WriteLine("You won.");
                Console.ReadLine();
            }
            else
            {
                for (guess = 0; guess < 4; guess++)
                {
                    Console.WriteLine("You didn't guess the correct number.");
                    Console.ReadLine();
                }
            }
        }
    }
}
