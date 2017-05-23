using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Entities;

namespace TryingAgain.Models
{
    public class CreateVisitor : IEnumerable
    {
        public List<Visitor> Visitors { get; set; }
        public string Message { get; internal set; }
        public string Name { get; internal set; }

        public CreateVisitor()
        {
            Visitors = new List<Visitor>();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}