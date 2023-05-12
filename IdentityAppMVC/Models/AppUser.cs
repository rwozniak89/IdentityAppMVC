using Microsoft.AspNetCore.Identity;

namespace IdentityAppMVC.Models
{
    public class AppUser : IdentityUser
    {
        public string NickName { get; set; }
    }
}
