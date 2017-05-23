using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Friends
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            bool stayInLoop = true;
          

            while (stayInLoop)
            {
                Console.WriteLine("Enter a name or hit the 'Enter' key to exit.");
                var input = Console.ReadLine();
                names.Add(input);

                if (names.Count == 1)
                {
                    Console.WriteLine("Your friend " + input + " likes your post.");
                    //Console.ReadLine();
                }
                else if (names.Count <= 2)
                {
                    Console.WriteLine("Your friends {0} and {1} like your post.", names[0], names[1]);
                    //Console.ReadLine();
                }
                else if(names.Count >= 3)
                {
                    Console.WriteLine("Your friends {0}, {1}, {2} ", names[0], names[1], names[2]  + " and "  + (names.Count-3) + " other friends." );
                    
                    //Console.ReadLine();

                }
                
                else if (String.IsNullOrWhiteSpace(names.LastOrDefault()))
                {
                    Console.WriteLine("No name entered. Exiting.");
                    Console.ReadLine();
                    stayInLoop= false;
                }

            }
        }
    }
}
