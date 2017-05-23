using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreNewStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by hyphens.");
            var input = Console.ReadLine();
            
            if (String.IsNullOrWhiteSpace(input))
                return; 
                       
            else
            {
                var numbers = new List<int>();
                foreach (var number in input.Split('-'))
                    numbers.Add(Convert.ToInt32(number));


                var nonDups = new List<int>();
                var includesDups = false;
                foreach (var number in numbers)
                {
                    if (!nonDups.Contains(number))
                       nonDups.Add(number);
                    else
                        includesDups = true;
                                        
                }
                if (includesDups)
                    Console.WriteLine("Duplicates");
                Console.ReadLine();


            }
        }

    }
}

