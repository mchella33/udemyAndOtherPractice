using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name.");
            string name = Console.ReadLine();

            if (name == null)
            {
                Console.WriteLine("Please enter a name");
                Console.ReadLine();
            }

            char[] array = name.ToCharArray();
            Array.Reverse(array);
            
            Console.WriteLine(array);
            Console.ReadLine();


        }
    }
}
