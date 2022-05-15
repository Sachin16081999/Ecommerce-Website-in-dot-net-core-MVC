﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Display(Name = "List Price")]
        [Range(1,100000)]
        public double ListPrice { get; set; }
        [Required]
        [Display(Name = "Price")]
        [Range(1,100000)]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Price for 51-100")]
        [Range(1,100000)]
        public double Price50 { get; set; }

        [Required]
        [Display(Name = "Price for 100+")]
        [Range(1,100000)]
        public double Price100 { get; set; }
        [ValidateNever]
        public string ImageUrl { get; set; }
        [Required]
        [Display(Name="Category")]
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category Category { get; set; }
        [Required]
        [Display(Name = "Cover Type")]
        public int CoverTypeId { get; set; }
        [ValidateNever]
        public CoverType CoverType { get; set; }  



    }
}