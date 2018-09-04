using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FinalTestQ1.Models
{
    public class Number
    {
        [Required]
        [Display(Name = "Please enter a number")]
        [Range(1, 1000, ErrorMessage = "Value must be between 1 and 1000.")]
        public int FirstNum { get; set; }

        [Required]
        [Display(Name = "Please enter a number")]
        [Range(1, 1000, ErrorMessage = "Value must be between 1 and 1000.")]
        public int SecondNum { get; set; }

        public int Sum { get; set; }
    }
}