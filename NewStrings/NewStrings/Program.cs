using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 numbers separated by a hyphen");  // ask for numbers to be entered
            var input = Console.ReadLine(); // read those entries
            var numbers = new List<int>(); // declare new list

            foreach (var number in input.Split('-')) // loop through numbers entered. Add them to the list and sort them removing the hyphen
            
                numbers.Add(Convert.ToInt32(number));
                numbers.Sort();
            

            var isConsecutive = true; // checking if consecutive numbers
            for (var i = 1; i < numbers.Count; i++) // loop through numbers until you review all entered
            {
                if (numbers[i] != numbers[i-1] + 1) // if the number is not equal to the number + 1
                {
                    isConsecutive = false;
                    break;
                }
            }
            var message = isConsecutive ? "Consecutive" : "Not Consecutive"; //Compare and display results
            Console.ReadLine();
        }

    }
}
    

