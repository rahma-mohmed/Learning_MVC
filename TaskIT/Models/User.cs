using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TaskIT.Models
{
    public class User
    {
         public int Id { get; set; }

         [Required(ErrorMessage ="Name is required")]
         [Display(Name = "User Name:")]
         public string Name { get; set; }

         [Required(ErrorMessage = "Password is required")]
         [DataType(DataType.Password)]
         [Display(Name = "Password:")]
         public string Password { get; set; }
         [Display(Name = "Password:")]
         [DataType(DataType.Password)]
        public string RePassword { get; set; }
         [Required(ErrorMessage = "Email is required")]
         //[EmailAddress]
         [RegularExpression(@"\w+\@gmail.com", ErrorMessage = "invalid email, must contain @")]
         [Display(Name = "Email:")]
         public string Email { get; set; }
    }
}

