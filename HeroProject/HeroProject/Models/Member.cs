using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HeroProject.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string HeroName { get; set; }
        public string UserName { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime LastLogin { get; set; }

        //public int ProfileID { get; set; }
        public virtual Profile Profile { get; set; }
        //public int MemberID { get; set; }
        public virtual Friend Friend { get; set; }
        //public int MessageID { get; set; }
        public virtual Message Message { get; set; }
    }
}