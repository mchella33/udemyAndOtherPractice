﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructing
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "John");
            // or just use var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
           
        }
    }
}