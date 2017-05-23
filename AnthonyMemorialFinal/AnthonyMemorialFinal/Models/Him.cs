using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AnthonyMemorialFinal.Models
{
    public class Him
    {
        public System.Guid SubmitterId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your name. You can post using Anonymous if you would like", AllowEmptyStrings = false)]
        public string SubmitterName { get; set; }
        public string Picture { get; set; }
        public string Tribute { get; set; }
        public string Story { get; set; }
        public System.DateTime Date { get; set; }

    }
}