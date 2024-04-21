using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Job_offers.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [DisplayName("أسم المستخدم")]
        public string Name {  get; set; }

        [Required]
        [DataType(DataType.Password)]
        [DisplayName("كلمه المرور")]
        public int Password { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public string Account_Type { get; set; }
    }
}
