using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FishingAround.Models
{
    public class Guests
    {
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your name. You can post using Anonymous if you would like", AllowEmptyStrings = false)]
        public string Name { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Enter any message you would like to leave for the family here.", AllowEmptyStrings = false)]
        public string Message { get; set; }
        public System.DateTime DatePosted { get; set; }
    }
}