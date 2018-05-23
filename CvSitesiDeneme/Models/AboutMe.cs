using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class AboutMe
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Objective { get; set; }
        public string WhatIDo { get; set; }
    }
}