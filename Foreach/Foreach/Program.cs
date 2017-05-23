using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
                Console.Read();
            }
            foreach (var character in name)
            {
                Console.WriteLine(character);
                Console.ReadLine();
            }
        }
    }
}
