using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooFastOrTooSlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the posted speed limit?");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your actual speed?");
            int actualSpeed = Convert.ToInt32(Console.ReadLine());
            int demerit = 0;

            if (speedLimit >= actualSpeed)
            {
                Console.WriteLine("Your speed is OK.");
                Console.ReadLine();
            }
            else if (actualSpeed >= speedLimit)
            {
               demerit = (actualSpeed-speedLimit)/5;
                if (demerit < 12)
                {
                    Console.WriteLine("You have just earned " + demerit + " total demerits.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your license has been suspended!");
                    Console.ReadLine();
                }
            }
        }
    }
}
