using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePracticeOnTimesAndDates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a time value in the 24-hour time format.");
            var input = Console.ReadLine();

            DateTime dt = new DateTime();
            String.Format("{0:h hh H HH}", dt);
        }
    }
}
