using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DuzceUniversityWebApi.Model
{
    public class AppIdentityDbContext : IdentityDbContext<UserModel>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
           : base(options) { }

        public DbSet<Students> students { get; set; }
    }
}
