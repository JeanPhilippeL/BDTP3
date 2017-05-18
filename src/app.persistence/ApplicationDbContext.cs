using app.domain.artiste;
using app.domain.client;
using app.domain.company;
using app.domain.contrat;
using app.domain.facture;
using app.domain.groupe;
using app.domain.membre;
using Microsoft.EntityFrameworkCore;


namespace app.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artiste> Artiste { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Contrat> Contrat { get; set; }
        public DbSet<Facture> Facture { get; set; }
        public DbSet<Groupe> Groupe { get; set; }
        public DbSet<Membre> Membre { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
    }
}
