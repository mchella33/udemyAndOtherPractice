﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructing
{
    class Customer
    {
        public int Id;
        public string Name;

        public Customer(int id)
        {
            this.Id = id;
        }
        public Customer(int id, string name )
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
