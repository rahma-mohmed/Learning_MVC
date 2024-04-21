using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    public class Department
    {
        public int Id { get; set; }
        
        [Display(Name ="Dept Name")]//Label 
        //[DataType(DataType.EmailAddress)]
        [Required]
        [RegularExpression(pattern:"^[a-zA-Z]{3,}$")]
        public string Name { get; set; }
        public string  ManagerName { get; set; }
    }
}