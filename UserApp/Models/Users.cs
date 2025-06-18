using Microsoft.AspNetCore.Identity;

namespace UserApp.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
