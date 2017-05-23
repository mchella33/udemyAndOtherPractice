using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedingTicket
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter Speed Limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your speed");
            var rateOfSpeed = Convert.ToInt32(Console.ReadLine());
            int demerit = ((rateOfSpeed - speedLimit) / 5);

            if(rateOfSpeed<= speedLimit)
            {
                Console.WriteLine("OK");
                Console.ReadLine();
            }
            else if (rateOfSpeed > speedLimit)
            {


                if ((rateOfSpeed-speedLimit)/5 <12)
                {
                    Console.WriteLine("Total demerit points: " + demerit);
                    Console.ReadLine();
                }
                else if ((rateOfSpeed - speedLimit) / 5 >= 12)
                {
                    Console.WriteLine("License suspended");
                    Console.ReadLine();
                }
                
            }
            
            
        }
    }
}