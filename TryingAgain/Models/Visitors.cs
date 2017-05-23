using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Entities;
using TryingAgain.Models;

namespace TryingAgain.Models
{
    public class Visitors
    {
        //public System.Guid VisitorId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public System.DateTime DatePosted { get; set; }
    }

}