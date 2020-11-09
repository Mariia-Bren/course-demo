using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseDemoApplication.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        public double Longtitude { get; set; }
        public double Latitude { get; set; }
    }
}