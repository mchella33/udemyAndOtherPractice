using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SayWhat
{
    class Program
    {
       

        static void Main(string[] args)
        {
            string s = "Portrait";
            string r = "Landscape";

            
            Console.WriteLine("Enter the height of your picture.");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width.");
            int width = Convert.ToInt32(Console.ReadLine());

            var orientation = (height > width) ? s : r;

            Console.WriteLine("Your image is a " + orientation);
            Console.ReadLine();

        }
    }
}
