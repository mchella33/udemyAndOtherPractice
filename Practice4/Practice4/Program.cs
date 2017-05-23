using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number or enter 'ok' to exit.");
            var input = Console.ReadLine();
            
            
            while(input != "ok")
            {
                int x = Convert.ToInt32(input);
                
                
                Console.WriteLine("The total of numbers entered is " + x);
                Console.ReadLine();
                continue;
            }

        }
        
    }
}
