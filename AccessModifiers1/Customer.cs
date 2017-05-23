using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers1
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating ==0)
                Console.WriteLine("Promoted to Level 1");
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }
        }

        public int CalculateRating()
        {
            return 0;
        }
    }
}
