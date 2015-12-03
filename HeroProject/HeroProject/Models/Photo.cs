using System;

namespace HeroProject.Models
{
    public class Photo
    {
        public int PhotoID { get; set; }
        public string FileLocation { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public Boolean ProfilePicture { get; set; }
    }
}