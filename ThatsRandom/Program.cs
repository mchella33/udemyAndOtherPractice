using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThatsRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var number = new Random().Next(1, 10);

            Console.WriteLine("The secret number is " + number);
            Console.ReadLine();

            Console.WriteLine("Enter a guess");
            int guess = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 4; i++)
                if (guess == number)
                {
                    Console.WriteLine("You guessed correctly!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You did not guess the secret number.");
                    Console.ReadLine();
                }
        }
    }
}
