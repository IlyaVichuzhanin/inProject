using inProject.Models.Domain;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace inProject.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<ApplicationUser>? ApplicationUsers { get; set; }
        public virtual DbSet<Company>? Companies { get; set; }
        public virtual DbSet<Employee>? Employees { get; set; }
        public virtual DbSet<PetexPrimaryLog>? PetexPrimaryLogs { get; set; }
        public virtual DbSet<Resource>? Resources { get; set; }
        public virtual DbSet<Session>? Sessions { get; set; }
        public virtual DbSet<Software>? Softwares { get; set; }
        public virtual DbSet<SoftwareModule>? SoftwareModules { get; set; }
        public virtual DbSet<SoftwareUser>? SoftwareUsers { get; set; }
        public virtual DbSet<StructuredLog>? StructuredLogs { get; set; }
        public virtual DbSet<tNavPrimaryLog>? tNavPrimaryLogs { get; set; }

    }
}
