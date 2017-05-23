using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Anthony.Models
{
    public class PostViewModel
    {
        public System.Guid PostId { get; set; }
        public System.Guid GuestId { get; set; }
        public string Url { get; set; }
        public string Comment { get; set; }
        public System.DateTime DatePosted { get; set; }
    }
}