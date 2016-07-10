using System.ComponentModel.DataAnnotations;
using NotesManager.Domain.Entities;

namespace NotesManager.WebUI.Models
{
    public class LogOnModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class RegisterModel
    {
        [Required]
        [Display(Name = "Login")]
        public string UserName { get; set; }       

        [Required]
        [StringLength(100, ErrorMessage = "Password should be between 6 to 20 characters", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Role")]
        public int Role { get; set; }

        public static tbUser FillNote(tbUser user, RegisterModel rm)
        {
            user.NAME = rm.UserName;
            user.PASSWORD = rm.Password;           
            
            return user;
        }
    }
}