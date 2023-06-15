using inProject.Data;
using inProject.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace inProject.Utilites
{
    public class DbInitializer : IDbInitializer
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DbInitializer(AppDbContext context,
                            UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public void Initialize()
        {
            if(!_roleManager.RoleExistsAsync(AppRoles.AppAdmin).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(AppRoles.AppAdmin)).GetAwaiter();
                _roleManager.CreateAsync(new IdentityRole(AppRoles.AppUser)).GetAwaiter();
                _userManager.CreateAsync(new ApplicationUser()
                {
                      UserName = "admin@gmail.com",
                      Email= "admin@gmail.com",
                      FirtsName = "Super",
                      LastName = "Admin"
                },"1qazZAQ!").GetAwaiter();

                var appUser = _context.ApplicationUsers.FirstOrDefault(x => x.Email == "admin@gmail.com");
                if (appUser != null)
                {
                    _userManager.AddToRoleAsync(appUser, AppRoles.AppAdmin).GetAwaiter().GetResult();
                }
                _context.SaveChanges();
            }
        }
    }
}
    