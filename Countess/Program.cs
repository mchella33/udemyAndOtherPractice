using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Countess
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\User\Desktop\TestingSignOffDocument.xlsx";
            string longestWord = "";
            if (File.Exists(path))
            {
                foreach(var item in path)
                {
                    if (item > longestWord.Length)
                        longestWord = ToString(item);
                }
            }
        }
    }
}
