using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseDemoApplication.Models
{
    public class Picture
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }
        public ApplicationUser User { get; set; }

        public Category Category { get; set; }

    }
}