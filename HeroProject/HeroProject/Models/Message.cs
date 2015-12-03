using System;

namespace HeroProject.Models
{
    public class Message
    {
        public int MessageID { get; set; }
        public string MessageText { get; set; }
        public DateTime DateSent { get; set; }
        public Boolean MessageRead { get; set; }
        public int ThreadID { get; set; }
    }
}