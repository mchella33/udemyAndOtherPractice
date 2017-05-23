using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Web;

namespace TryingAgain.Models
{
    public class Pictures
    {
        public System.Guid PictureId { get; set; }
        public string PictureUrl { get; set; }
        public string DateOfPicture { get; set; }
        public string VisitorName { get; set; }
        public string Caption { get; set; }
        public System.DateTime DatePicturePosted { get; set; }
    }
}