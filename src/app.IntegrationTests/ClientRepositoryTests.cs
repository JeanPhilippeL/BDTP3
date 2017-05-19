using System;
using System.Collections.Generic;
using System.Linq;
using app.persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Xunit;
using app.domain.client;

namespace app.IntegrationTests
{
    public class ClientRepositoryTests
    {
        private ApplicationDbContextFactory _dbContextFactory;
        private readonly DbContextOptionsBuilder<ApplicationDbContext> _dbContextOptionsBuilder;
        private readonly ClientFrameworkRepository<Client> _clientRepository;

        public ClientRepositoryTests()
        {
            _dbContextFactory = new ApplicationDbContextFactory();

            var dbContext = _dbContextFactory.Create();
            ClearAllTables(dbContext);
            _clientRepository = new ClientFrameworkRepository<Client>(dbContext);
        }

        [Fact]
        public void Add_Client_ToDatabase()
        {
            //Arrange
            var item = new Client()
            {
                ID_CLIENT = 1,
                NOM_CLIENT = "Travis Clint",
                REFERENCE = "",
                TELEPHONE_CLIENT = "5817777777"
            };

            //Action
            _clientRepository.Add(item);

            // Assert
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Client.ToList().Count.Should().Be(1);
            }
        }

        [Fact]
        public void Remove_ExistingCompany_DeletesCompanyFromDatabase()
        {
            //Arrange
            var companies = new List<Client>()
            {
                new Client()
                {
                    ID_CLIENT = 1,
                    NOM_CLIENT = "Travis Clint",
                    REFERENCE = "",
                    TELEPHONE_CLIENT = "5817777777"
                },
                new Client()
                {
                    ID_CLIENT = 2,
                    NOM_CLIENT = "Daniel Lorent",
                    REFERENCE = "",
                    TELEPHONE_CLIENT = "5817777777"
                }
            };

            var itemsCountBefore = companies.Count;
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Client.AddRange(companies);
                apiDbContext.SaveChanges();
            }

            //Action
            _clientRepository.Delete(companies.ElementAt(0));

            // Assert
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Client.ToList().Count.Should().Be(itemsCountBefore - 1);
            }
        }

        private void ClearAllTables(ApplicationDbContext dbContext)
        {
            dbContext.Client.RemoveRange(dbContext.Client.ToList());
            dbContext.SaveChanges();
        }
    }
}

