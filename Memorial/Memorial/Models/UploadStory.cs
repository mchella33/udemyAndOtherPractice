using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Memorial.Models
{
    public class UploadStory
    {
        public System.Guid SubmitterId { get; set; }
        public string SubmitterName { get; set; }
        public string Picture { get; set; }
        public string Story { get; set; }
        public System.DateTime Date { get; set; }
    }
}