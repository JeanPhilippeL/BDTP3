using app.domain;
using Microsoft.EntityFrameworkCore;

namespace app.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
    }
}
