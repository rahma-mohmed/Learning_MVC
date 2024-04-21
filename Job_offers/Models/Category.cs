﻿using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Job_offers.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "نوع الوظيفة")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "وصف النوع")]
        public string CategoryDescription { get; set; }
        public virtual ICollection<Job> Jobs { get; set;}
    }
}
