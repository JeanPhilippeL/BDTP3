using app.domain.company;
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

            var companiesRepositories = new EntityFrameworkRepository<Company>(dbContext);
            var clientRepositories = new EntityFrameworkRepository<Client>(dbContext);
            companiesRepositories.Add(
                new Company()
                {
                    Name = "GitLab"
                });
        }
    }
}