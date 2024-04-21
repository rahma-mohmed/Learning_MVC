using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class Department 
    {
        public int Id { get; set; }
        [Display(Name="Department Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        public string Manager { get; set; }
    }
}
