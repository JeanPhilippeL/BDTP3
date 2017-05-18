using app.domain.artiste;
using app.domain.client;
using app.persistence;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace app.console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var dbContextFactory = new ApplicationDbContextFactory();

            var dbContext = dbContextFactory.Create(new DbContextFactoryOptions());

            var ArtistRepositories = new ArtistFrameworkRepository<Artiste>(dbContext);
            var clientRepositories = new ClientFrameworkRepository<Client>(dbContext);
            ArtistRepositories.Add(
                new Artiste()
                {
                    NOM_ARTISTE = "IciNomArtist",
                    PRENOM_ARTISTE = "IciPrenomArtist"
                });
            clientRepositories.Add(
                new Client()
                {
                    NOM_CLIENT = "IciNomCLient"
                });
        }
    }
}