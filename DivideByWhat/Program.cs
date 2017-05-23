using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount;
            Console.WriteLine("Enter a number you would like to divide 100 by or enter 'ok' to exit");
            var input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 100; i++)
            {
                
                while (input.ToString() != "ok")
                {
                    totalCount = (100 / input);

                    Console.WriteLine("The total number of times " + input + " goes in to 100 is " + totalCount);
                    Console.WriteLine("Enter your next number to divide 100 by.");

                    int newInput = Convert.ToInt32(Console.ReadLine());
                    totalCount = (100 / newInput);
                    Console.WriteLine("The total number of times " + newInput + " goes in to 100 is " + totalCount);
                    Console.WriteLine("Continue to enter your next number or hit 'ok' to exit.");
                    Console.ReadLine();

                    
                }
                if (input.ToString() == "ok")
                {
                    Console.WriteLine("You exited the program.");
                    Console.ReadLine();
                    break;
                }

            }
           
        }
    }
}
    

    

