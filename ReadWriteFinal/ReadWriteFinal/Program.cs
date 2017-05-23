using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compose a string that consists of three lines.
            string lines = "First line.\r\nSecond line.\r\nThird line.";

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter("c:/Users/User/Desktop/input.txt");
            file.WriteLine(lines);

            file.Close();

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            //System.IO.StreamReader file =
            //   new System.IO.StreamReader("c:/Users/User/Desktop/input.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                counter++;
            }

            file.Close();

            // Suspend the screen.
            Console.ReadLine();




        }
    }
}
