using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace YouSaidWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 10);

            Console.WriteLine("Can you guess the secret number? ( It is " + secretNumber + ").");
            Console.ReadLine();


            for (int i = 0; i < 4; i++)

            {
                Console.WriteLine("Enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess != null)
                {
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("You guessed correctly!");
                        Console.ReadLine();
                    }
                    //else if (guess == null)
                    //{
                    //    Console.WriteLine("You must enter a guess.");
                    //    Console.ReadLine();
                    //}
                    else
                    {
                        Console.WriteLine("You didn't guess the secret number.");
                        Console.ReadLine();
                    }

                }
               
            }
        }
    }
}

