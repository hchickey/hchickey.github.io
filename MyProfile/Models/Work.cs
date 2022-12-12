using System;

namespace MyProfile.Models
{
    public class Work
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        public string Website { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Summary { get; set; }
    }
}
