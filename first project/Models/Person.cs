using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace first_project.Models
{
    public class Person
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string Code { get; set; }
    }
}