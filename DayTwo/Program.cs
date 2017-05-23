using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            double mealCost = Convert.ToDouble(Console.ReadLine());
            int tipPercent = Convert.ToInt32(Console.ReadLine());
            int taxPercent = Convert.ToInt32(Console.ReadLine());

            var tip = mealCost * tipPercent / 100;
            var tax = mealCost * taxPercent / 100;
            var totalCost = (mealCost + tip + tax);

            Console.WriteLine("The total meal cost is " + (Math.Round(totalCost)) + " dollars.");



            //int i = 4;
            //double d = 4.0;
            //string s = "HackerRank ";

            //int a;
            //double b;
            //string c;

            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToDouble(Console.ReadLine());
            //c = Console.ReadLine();

            //Console.WriteLine(i + a);
            //Console.WriteLine((d + b).ToString("N1"));
            //Console.WriteLine(s + c);
            //Console.ReadLine();

            // above Commented out section is actually labeled DayOne in HackerRank


        }
    }
}
