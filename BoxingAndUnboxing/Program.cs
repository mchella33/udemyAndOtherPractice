﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("chelle");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            anotherList.Add();
            var names = new List<string>();
            names.Add();
        }
    }
}
