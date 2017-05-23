using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatAmI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height of your image.");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width of your image.");
            int width = Convert.ToInt32(Console.ReadLine());

            var orientation = height > width ? "portrait" : "landscape";
            Console.WriteLine("The orientation of your image is " + orientation);
            Console.ReadLine();
        }
    }
}
