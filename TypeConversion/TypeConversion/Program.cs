using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte b = 1;
            //int i = b;
            //Console.WriteLine(i);

            //int i = 1000;
            //byte b = (byte) i;

            //Console.WriteLine(b);
            //Console.ReadLine();

            //var number = "1234";
            //int i = Convert.ToInt32(number);
            //Console.WriteLine(i);
            //Console.ReadLine();
            //try
            //{
            //    var number = "1234";
            //    byte b = Convert.ToByte(number);
            //    Console.WriteLine(b); //value too large byte doesn't fit
            //}
            //catch (Exception)
            //{
            //    Console.WriteLine("The number could not be converted to a byte.");
            //    Console.ReadLine();
            //}
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
                Console.ReadLine();

            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be converted to a byte.");
            }

            

        }
    }
}
