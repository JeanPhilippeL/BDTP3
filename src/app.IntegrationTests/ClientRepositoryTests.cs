using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;
using app.persistence;
using app.domain.client;
using app.IntegrationTests.MocksEntities;

namespace Tests
{
    public class ClientRepositoryTests
    {
        private ApplicationDbContextFactory _dbContextFactory;
        private readonly ClientFrameworkRepository<Client> _clientRepository;

        public ClientRepositoryTests()
        {
            _dbContextFactory = new ApplicationDbContextFactory ();

            var dbContext = _dbContextFactory.Create();
            _clientRepository = new ClientFrameworkRepository<Client>(dbContext);
        }

        [Fact]
        public void Add_Client_ToDatabase()
        {
            // Peuplement de la base de données pour les tests 
            //   |_ J'ai fait des mock, mais je ne parvenais pas à convertir MockClient en Client.
            //   |_ ex init de la variable clientMock : var clientMock = new MockClient[0];
            var client = new Client()
            {
                ID_CLIENT = 1,
                NOM_CLIENT = "Dannick Lavoie",
                TELEPHONE_CLIENT = "4187771234",
            };


            _clientRepository.Add(client);


            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Clients.ToList().Count.Should().Be(1);
            }
        }

        [Fact]
        public void Remove_ExistingClient_FromDatabase()
        {
            var clients = new List<Client>()
            {
            new Client() {
                    ID_CLIENT = 1,
                    NOM_CLIENT = "Dannick Lavoie",
                    TELEPHONE_CLIENT = "4187771234",
                },
            new Client() {
                    ID_CLIENT = 1,
                    NOM_CLIENT = "BecauseHeHaveName",
                    TELEPHONE_CLIENT = "5817771818",
                }
            };
            var itemsCountBefore = clients.Count;
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Clients.AddRange(clients);
                apiDbContext.SaveChanges();
            }


            _clientRepository.Delete(clients.ElementAt(0));


            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Clients.ToList().Count.Should().Be(itemsCountBefore - 1);
            }
        }

        [Fact]
        public void Add_Client_WithoutRequiredData_ErrorWasThrow()
        {
            var client = new Client()
            {
                NOM_CLIENT = "BadCLient",
            };
            bool error = false;


            try
            {
                _clientRepository.Add(client);
            }
            catch
            {
                error = true;
            }


            Assert.True(error);
        }



        private void ClearAllTables(ApplicationDbContext dbContext)
        {
            dbContext.Clients.RemoveRange(dbContext.Clients);
            dbContext.SaveChanges();
        }
    }
}