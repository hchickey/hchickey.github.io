using System;
using System.Data.Common;

namespace MyProfile.Models
{
    public class Education
    {
        public int Id {get; set;}
        public string School { get; set;}
        public string Area { get; set;}
        public string StudyType { get; set;}
        public DateTime StartDate { get; set;}
        public DateTime EndDate { get; set;}
    }
}
