using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class AllOf
    {
        public int Id { get; set; }
        public virtual List<AboutMe> Aboutme { get; set; }
        public virtual List<Certificated> Certificated { get; set; }
        public virtual List<Contact> Contact { get; set; }
        public virtual List<Entery> Entery { get; set; }
        public virtual List<Education> Education { get; set; }
        public virtual List<Skill> Skills { get; set; }
        public virtual List<Experiance> Experiance { get; set; }

    }
}