using System;
using System.ComponentModel.DataAnnotations;

namespace HeroProject.Models
{
    public class Friend
    {
        [Key]
        public int MemberID { get; set; }
        public DateTime DateFriended { get; set; }
    }
}