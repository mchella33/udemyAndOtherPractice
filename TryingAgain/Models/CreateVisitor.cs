using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Models;
using TryingAgain.Entities;

namespace TryingAgain.Models
{
    public class CreateVisitorInput
    {
        public System.Guid VisitorId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public System.DateTime DatePosted { get; set; }
    }
}