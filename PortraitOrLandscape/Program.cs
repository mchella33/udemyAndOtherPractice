using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortraitOrLandscape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of your picture.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of your picture.");
            int width = Convert.ToInt32(Console.Read());
            string shape;
            if
                (height > width ? "Portrait" : "Landscape")
            {
                Console.WriteLine("Your image is a " + shape);
                Console.ReadLine();
            }
        }


    }
    
}