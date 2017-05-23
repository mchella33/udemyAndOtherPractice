using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WatchWhat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("Michelle");
            
        }
    }
}
