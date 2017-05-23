using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatClassDoYouHave
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(1, "John");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.ReadLine();

            var order = new Order();
            //customer.Orders = new List<Order>();
            customer.Orders.Add(order);

        }
    }
}
