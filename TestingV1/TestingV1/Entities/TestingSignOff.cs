//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestingV1.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class TestingSignOff
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
