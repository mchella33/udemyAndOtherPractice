using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Glossary
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"‪C:\Users\User\Desktop\input.txt";

            if (!File.Exists(path))
            {
                string createText = "" + Environment.NewLine;
                File.WriteAllText(path, createText, Encoding.UTF8);

            }

            string appendText = "This is extra text" + Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.UTF8);

            string readText = File.ReadAllText(path);
            Console.WriteLine(readText);

        }
    }
}
