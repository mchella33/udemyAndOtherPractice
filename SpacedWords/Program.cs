using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacedWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few words with spaces.");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid entry");
            }
            
        }
            
    }
   
}
