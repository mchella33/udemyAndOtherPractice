﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Mosh";
            bool isWorking = true;

            Console.WriteLine(count);
            Console.WriteLine(number);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);


            const float Pi = 3.14f;

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.ReadLine();


        }
    }
}