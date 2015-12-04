namespace HeroProject.Models
{
    public class Profile
    {
        public int ProfileID { get; set; }
        public string Bio { get; set; }
        //public int InterestID { get; set; }
        public virtual Interest Interests { get; set; }
        public int PhotoID { get; set; }
        public virtual Photo Photo { get; set; }
        public virtual Demographics Demographics { get; set; }
        public int ID { get; set; }
    }
}