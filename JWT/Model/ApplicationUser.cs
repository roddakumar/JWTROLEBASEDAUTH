using Microsoft.AspNetCore.Identity;

namespace JWT.Model
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}