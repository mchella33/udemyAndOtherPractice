using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    class Customer
    {
        public int Id;
        public string Name;

        public List<Order> Orders;

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name)
            :this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
            Orders = new List<Order>();
        }
    }
}
