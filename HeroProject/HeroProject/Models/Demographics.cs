using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroProject.Models
{
    public class Demographics
    {
        public int DemographicsID { get; set; }
        
        public string City { get; set; }
       
        public string State { get; set; }
       
        public string Country { get; set; }
        
        public DateTime BirthDate { get; set; }
       
        public string Gender { get; set; }
       
    }
}