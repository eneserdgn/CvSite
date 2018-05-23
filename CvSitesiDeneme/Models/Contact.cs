using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CvSitesiDeneme.Models
{
    public class Contact
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
