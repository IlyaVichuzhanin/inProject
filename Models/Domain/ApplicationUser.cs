using Microsoft.AspNetCore.Identity;

namespace inProject.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirtsName { get; set; }
        public string? LastName { get; set; }
    }
}
