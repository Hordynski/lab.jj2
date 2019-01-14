using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Lab.JJ2.Models
{
    public class Product
    {
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        [MaxLength(10)]
        public string Category { get; set; }
    }
}