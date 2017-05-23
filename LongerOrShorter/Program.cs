using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerOrShorter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter how tall your item is.");
            int tall = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter how wide your item is.");
            int wide = Convert.ToInt32(Console.ReadLine());

            var orientation = (tall > wide) ? "taller than it is wide." : "wider than it is tall.";

            Console.WriteLine("Your image is " + orientation);
            Console.ReadLine();
        }
    }
}
