using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Entities;

namespace TryingAgain.Models
{
    public class UploadPictureViewModel
    {
        public List<Picture> Pictures { get; set; }

        public UploadPictureViewModel()
        {
            Pictures = new List<Picture>();
        }
    }
}