using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValidOrInvalid
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input >= 1 && input <= 10)
                {
                    Console.WriteLine("Valid");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("InValid");
                    Console.ReadLine();
                    break;
                }
                
                
            }
           

        }
    }
}
