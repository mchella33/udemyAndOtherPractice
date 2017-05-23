using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Anthony.Models
{
    public class GuestsViewModel
    {
        public System.Guid GuestId { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your first name. You can post using Anonymous if you would like",AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your last name. You can post using Anonymous if you would like", AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [StringLength(100)]
        [Required(ErrorMessage = "Please enter an email address", AllowEmptyStrings = false)]
        public string Email { get; set; }
        public DateTime DateSigned { get; set; }
        
    }
}