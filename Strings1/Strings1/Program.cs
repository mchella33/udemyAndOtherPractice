using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Michelle Wright";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.ReadLine();

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);
            Console.ReadLine();

            fullName.Replace("Michelle", "Chelle");
            fullName.Replace('o', '0');
            Console.WriteLine(firstName + lastName);
            Console.ReadLine();


        }
    }
}
