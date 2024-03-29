﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Image {  get; set; }
        public int Age { get; set; }
        [ForeignKey("Department")]
        public int Dept { get; set; }
        public Department Department { get; set; }
    }
}
