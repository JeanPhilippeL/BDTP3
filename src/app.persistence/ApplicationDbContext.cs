using app.domain.company;
using app.domain.client;
using Microsoft.EntityFrameworkCore;

namespace app.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<Client> Client { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
    }
}
