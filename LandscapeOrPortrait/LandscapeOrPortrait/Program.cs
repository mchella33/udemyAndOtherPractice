using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandscapeOrPortrait
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of your picture");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the height of your picture");
            var height = Convert.ToInt32(Console.ReadLine());

            if (width> height)
            {
                Console.WriteLine("Your picture is in landscape format");
                Console.ReadLine();

            }
            else if(height>width)
            {
                Console.WriteLine("Your picture is in portrait format");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This picture is neither portrait or landscape");
                Console.ReadLine();
            }
        }
    }
}
