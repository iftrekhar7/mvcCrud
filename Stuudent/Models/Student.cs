using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Stuudent.Models
{
    public class Student
    {
        [Key]
        public int IDStudent { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(10)]
        public string RollNo { get; set; }

        [Required]
        [StringLength(5)]
        public string SscResult { get; set; }

        [Required]
        [StringLength(5)]
        public string HscResult { get; set; }

        [Required]
        [StringLength(5)]
        public string Cgpa { get; set; }


    }
}