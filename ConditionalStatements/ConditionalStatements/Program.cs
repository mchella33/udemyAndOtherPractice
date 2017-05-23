using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatements
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("It's Spring!");
                    Console.ReadLine();
                    break;
                case Season.Summer:
                    Console.WriteLine("It's summer!");
                    Console.ReadLine();
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn!");
                    Console.ReadLine();
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
            //int hour = 10;

            //if (hour > 0 && hour < 12)
            //    Console.WriteLine("It's morning.");
            //else if (hour >= 12 && hour < 18)
            //    Console.WriteLine("It's afternoon.");
            //else
            //    Console.WriteLine("it's evening.");

            //bool isGoldCustomer = true;

            ////float price;
            ////if (isGoldCustomer)
            ////    price = 19.95f;
            ////else
            ////    price = 29.95f;
            //float price = (isGoldCustomer) ? 19.95f : 29.95f;
            //Console.WriteLine(price);
            //Console.ReadLine();


        }
    }
}
