using app.domain.artiste;
using app.domain.client;
using app.domain.contrat;
using app.domain.facture;
using app.domain.groupe;
using app.domain.membre;
using Microsoft.EntityFrameworkCore;


namespace app.persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Artiste> Artistes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contrat> Contrats { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<Groupe> Groupes { get; set; }
        public DbSet<Membre> Membres { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }
    }
}
