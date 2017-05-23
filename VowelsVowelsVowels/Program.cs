using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace VowelsVowelsVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an English word.");
            string word = Console.ReadLine();
            var newWord = System.Text.RegularExpressions.Regex.Replace(word, "[aeiouAEIOU]", " ");

            Console.WriteLine(newWord);
            Console.ReadKey();

        }
    }
}
