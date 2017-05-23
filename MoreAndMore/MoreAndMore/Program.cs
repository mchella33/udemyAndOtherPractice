using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAndMore
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                Console.WriteLine("Enter any number or 'ok' to exit");
                var input = Console.ReadLine();
                if (input != "ok")
                {
                                      
                    sum += Convert.ToInt32(input);
                    Console.WriteLine("The total of the numbers entered is " + sum);
                    Console.ReadLine();
                    continue;

                }
                else
                    break;
            }
        }
    }
}
