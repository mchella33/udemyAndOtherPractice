using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
            Console.ReadLine();

        }
        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
            Console.ReadLine();
        }
    }
}
