using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NoRepeats
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"file:///C:/Users/User/Downloads/Exercises-Inheritance%20(1).pdf");

            System.Console.WriteLine("Contents of ", text);

            string[] lines = System.IO.File.ReadAllLines(@"‪file:///C:/Users/User/Downloads/Exercises-Inheritance%20(1).pdf");

            System.Console.WriteLine("Contents of = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
