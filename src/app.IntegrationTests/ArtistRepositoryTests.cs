using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Xunit;
using app.persistence;
using app.domain.artiste;
using app.IntegrationTests.MocksEntities;

namespace Tests
{
    public class ArtistRepositoryTests
    {
        private ApplicationDbContextFactory _dbContextFactory;
        private readonly ArtistFrameworkRepository<Artiste> _artistRepository;

        public ArtistRepositoryTests()
        {
            _dbContextFactory = new ApplicationDbContextFactory();

            var dbContext = _dbContextFactory.Create();
            _artistRepository = new ArtistFrameworkRepository<Artiste>(dbContext);
        }

        [Fact]
        public void Add_Artist_ToDatabase()
        {
            // Peuplement de la base de données pour les tests 
            //   |_ J'ai fait des mock, mais je ne parvenais pas à convertir MockArtiste en Artist.
            //   |_ ex init de la variable artistMock : var artistMock = new MockArtiste[0];
            var artists = new Artiste()
            {
                
                ID_ARTISTE = 1,
                NOM_ARTISTE = "Lavoie",
                PRENOM_ARTISTE = "Dannick",
                NAS = 123456789,
                TELEPHONE = "4187771234"
            };


            _artistRepository.Add(artists);


            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Artistes.ToList().Count.Should().Be(1);
            }
        }

        [Fact]
        public void Remove_ExistingArtist_FromDatabase()
        {
            var Artists = new List<Artiste>()
            {
            new Artiste() {
                    ID_ARTISTE = 1,
                    NOM_ARTISTE = "Dannick Lavoie",
                    PRENOM_ARTISTE = "4187771234",
                    NAS = 123456789,
                    TELEPHONE = "456456456"
                },
            new Artiste() {
                    ID_ARTISTE = 1,
                    NOM_ARTISTE = "Lavoie",
                    PRENOM_ARTISTE = "4187771234",
                    NAS = 123456789,
                    TELEPHONE = "456456456"
                }
            };
            var itemsCountBefore = Artists.Count;
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Artistes.AddRange(Artists);
                apiDbContext.SaveChanges();
            }


            _artistRepository.Delete(Artists.ElementAt(0));


            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Artistes.ToList().Count.Should().Be(itemsCountBefore - 1);
            }
        }

        [Fact]
        public void Add_Artist_WithoutRequiredData_ErrorWasThrow()
        {
            var artists = new Artiste()
            {
                NOM_ARTISTE = "BadArtist",
            };
            bool error = false;


            try
            {
                _artistRepository.Add(artists);
            }
            catch
            {
                error = true;
            }


            Assert.True(error);
        }



        private void ClearAllTables(ApplicationDbContext dbContext)
        {
            dbContext.Artistes.RemoveRange(dbContext.Artistes);
            dbContext.SaveChanges();
        }
    }
}