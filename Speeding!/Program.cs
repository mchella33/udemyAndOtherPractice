using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeding_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the posted Speed Limit.");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your actual speed.");
            int actualSpeed = Convert.ToInt32(Console.ReadLine());
            int demerit = (actualSpeed - speedLimit) / 5;

            if (actualSpeed < speedLimit)
            {
                Console.WriteLine("Speed ok");
                Console.ReadLine();
            }
            else if(actualSpeed >= speedLimit)
            {
                if (demerit >= 12)
                {
                    Console.WriteLine("Your license is suspended.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your total demerits is " + demerit);
                    Console.ReadLine();
                }
            }
        }
    }
}
