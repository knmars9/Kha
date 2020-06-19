using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool_1711060452.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser Lecturer { get; set; }
        
        public string LecturerId { get; set; }

        public string Place { get; set; }
        public DateTime dateTime { get; set; }
        public Category category { get; set; }
        public byte CategoryId { get; set; }
    }
    
}