﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreAndMoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //var builder = new StringBuilder("Hello World");
            //builder.Append('-', 10);
            //builder.AppendLine();
            //builder.Append("Header");
            //builder.AppendLine();
            //builder.Append('-', 10);

            //builder.Replace('-', '+');

            //builder.Remove(0, 10);

            //builder.Insert(0, new string('-', 10));
            //Console.WriteLine(builder);
            //Console.ReadLine();

            //same code written above and below, just optimized

            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                 .AppendLine()
                 .Append("Header")
                 .AppendLine()
                 .Append('-', 10)
                 .Replace('-', '+')
                 .Remove(0, 10)
                 .Insert(0, new string('-', 10));
            Console.WriteLine(builder);
            Console.ReadLine();

        }
    }
}
