using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LikeISaid
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create post.");
            string post = Console.ReadLine();

            Console.WriteLine("Do you like this post?....... " + "'" + post + "'. If so, enter your name. Otherwise hit 'enter' to move on.");
            var names = new List<string>();
            string name = Console.ReadLine();

            while (true)
            {
                names.Add(name);
                if (names.Count > 2)
                {
                    Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
                    Console.ReadLine();
                }
                else if (names.Count == 2)
                {
                    Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                    Console.ReadLine();
                }
                else if (names.Count == 1)
                {
                    Console.WriteLine("{0} likes your post.", names[0]);
                    Console.ReadLine();
                }
                else if (String.IsNullOrWhiteSpace(name))
                    break;


            }
            
            

        }
    }
}
