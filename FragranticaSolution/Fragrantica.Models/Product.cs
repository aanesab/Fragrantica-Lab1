﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fragrantica.Models
{
    public class Product
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Perfume Name")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [DisplayName("Serial Number")]
        public string SerialNumber { get; set; }
        [Required]
        [DisplayName("Perfume House")]
        public string PerfumeHouse { get; set; }

        [Required]
        [DisplayName("List Price")]
        [Range(20, 500)]
        public double Price { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
       // [ValidateNever]
        public Category Category { get; set; }
       // [ValidateNever]
        public string ImageUrl { get; set; }

    }
}

