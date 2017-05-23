using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadingRainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\User\Desktop\Exigo Commission Plan Testing Instructions.docx";
            var totalWords = 0;
            if(File.Exists(path))
            {
                var content = File.ReadAllText(path);

                string[] source = path.Split(new char[] { '.', '?', '!', ' ', ';', ',', ':' });
                totalWords = path.Count();

             }

            Console.WriteLine("The number of words in the file is: " + Convert.ToInt32(totalWords));
            Console.ReadLine();

        }
    }
}
