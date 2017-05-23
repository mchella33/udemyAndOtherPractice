using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadAndWrite
{
    class Program
    {
        public static void Main(string[] args)
        {
            int lineNumber = 1;

            foreach (string line in Resource1.input.Split('\n'))
            {
                if (lineNumber % 2 == 1)
                {
                    // title
                    Console.WriteLine(line);
                }
                else
                {
                    // detail
                    Console.WriteLine(line);
                }
                lineNumber++;
            }
            Console.ReadKey();
        }
    }
}
