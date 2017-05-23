using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace TryingAgain.Models
{
    public class Storys
    {
        public System.Guid StoryId { get; set; }
        public string Story1 { get; set; }
        public string StoryTeller { get; set; }
        public string Url { get; set; }
        public string DateOfStory { get; set; }
        public System.DateTime DatePosted { get; set; }
    }
}