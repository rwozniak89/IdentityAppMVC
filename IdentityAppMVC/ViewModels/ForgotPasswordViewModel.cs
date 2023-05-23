using System.ComponentModel.DataAnnotations;

namespace IdentityAppMVC.ViewModels
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }


    }
}
