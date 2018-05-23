using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class Experiance
    {
        public int ID { get; set; }
        public string StartDate { get; set; }
        public string StopDate { get; set; }
        public string JobName { get; set; }
        public string CompanyName { get; set; }
        public string Where { get; set; }
        public string Explanation { get; set; }
        public bool İsContinue { get; set; }

    }
}