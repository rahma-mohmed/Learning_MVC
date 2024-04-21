using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Day1.Models
{
    public class Student
    {
        public int ID { get; set; }
        [Display(Name="Student NAme")]
        [Required(ErrorMessage ="Name is required")]
        [RegularExpression(pattern:"^[a-zA-Z]{3,}$",ErrorMessage ="name must be character and at least 3 characters")]
        //[DataType(DataType.Date)]
        public string Name { get; set; }

        //[DataType(DataType.Password)]
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
        
        [Display(Name = "Profile Image")]
        [Required]
        [RegularExpression(@"\w+\.(jpg|png)")]
        public string Image { get; set; }

        [Range(minimum:20, maximum:50)]
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int Dept { get; set; }
        public Department Department { get; set; }

    }
}
