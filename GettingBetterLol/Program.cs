using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingBetterLol
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of your image.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of your image.");
            int width = Convert.ToInt32(Console.ReadLine());

            if (height > width)
            {
                Console.WriteLine("Your image is a Portrait.");
                Console.ReadLine();
            }
            else if (width > height)
            {
                Console.WriteLine("Your image is a Landscape.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your image is neither Landscape or Portrait.");
                Console.ReadLine();
            }
        }
    }
}
