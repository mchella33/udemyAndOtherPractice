using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingV1.Models
{
    public class TestingSignOffs
    {
        public System.Guid TesterId { get; set; }
        public int Version { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int VolumeBucket { get; set; }
        public int Rank { get; set; }
        public decimal Bonus { get; set; }
        public System.DateTime DateTested { get; set; }

    }
}