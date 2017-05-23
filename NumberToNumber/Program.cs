using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a serious a numbers separated by commas.");
            int input = Convert.ToInt32(Console.ReadLine());
            List<int> myList = new List<int>();

            if (input >= 0)
            {
                
                Console.WriteLine("The largest number of numbers entered is " + Math.Max(input));
                Console.ReadLine();

            }
            

            
        }


    }

}
