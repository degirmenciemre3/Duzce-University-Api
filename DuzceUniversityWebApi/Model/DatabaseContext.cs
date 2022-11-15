using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DuzceUniversityWebApi.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options) { }
        public DbSet<Duyuru> duyurulars { get; set; }
    }
}
