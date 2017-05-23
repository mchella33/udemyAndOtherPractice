using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gardening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the plant.");
            string name = Console.ReadLine();
            List<Plants> myPlants = new List<Plants>();
            
            myPlants.Add(new Plants());

            Console.WriteLine("The plant you entered is called a " + name);
            Console.ReadLine();

        }
    }
}
