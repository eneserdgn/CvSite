using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class Skill
    {
        public int ID { get; set; }
        public string SkillName { get; set; }
        public bool IsBest { get; set; }
        public int Match { get; set; }
        public int Level { get; set; }
    }
}