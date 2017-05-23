
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TryingAgain.Entities;

namespace TryingAgain.Models
{
    public class AddStoryViewModel
    {
        public List<Story> Storys { get; set; }

        public AddStoryViewModel()
        {
            Storys = new List<Story>();
        }
   
    }
}