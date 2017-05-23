using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreYouSure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the posted speed limit.");
            int speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your actual speed.");
            int actualSpeed = Convert.ToInt32(Console.ReadLine());

            int demerit = (actualSpeed - speedLimit)/5;

            if (actualSpeed < speedLimit)
            {
                Console.WriteLine("You are driving under the posted limit");
                Console.ReadLine();
            }
            if (speedLimit <= actualSpeed)
            {
                if (demerit < 12)
                {
                    Console.WriteLine("Your total number of demerits is " + demerit);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("You went too fast. You lost your license.");
                    Console.ReadLine();
                }
            }
        }
    }
}
