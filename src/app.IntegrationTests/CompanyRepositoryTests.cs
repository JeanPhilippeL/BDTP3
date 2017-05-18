using System;
using System.Collections.Generic;
using System.Linq;
using app.domain.company;
using app.persistence;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Xunit;
using app.domain.client;

namespace app.IntegrationTests
{
    public class CompanyRepositoryTests
    {
        private ApplicationDbContextFactory _dbContextFactory;
        private readonly DbContextOptionsBuilder<ApplicationDbContext> _dbContextOptionsBuilder;
        private readonly ClientFrameworkRepository<Company> _companyRepository;

        public CompanyRepositoryTests()
        {
            _dbContextFactory = new ApplicationDbContextFactory();

            var dbContext = _dbContextFactory.Create();
            ClearAllTables(dbContext);
            _companyRepository = new ClientFrameworkRepository<Client>(dbContext);
        }

        [Fact]
        public void Add_Company_AddsItemToDatabase()
        {
            //Arrange
            var item = new Company()
            {
                Name = "Google inc."
            };

            //Action
            _companyRepository.Add(item);

            // Assert
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Companies.ToList().Count.Should().Be(1);
            }
        }

        [Fact]
        public void Remove_ExistingCompany_DeletesCompanyFromDatabase()
        {
            //Arrange
            var companies = new List<Company>()
            {
                new Company()
                {
                    Name = "Travis CI"
                },
                new Company()
                {
                    Name = "GitHub"
                }
            };

            var itemsCountBefore = companies.Count;
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Companies.AddRange(companies);
                apiDbContext.SaveChanges();
            }

            //Action
            _companyRepository.Delete(companies.ElementAt(0));

            // Assert
            using (var apiDbContext = _dbContextFactory.Create())
            {
                apiDbContext.Companies.ToList().Count.Should().Be(itemsCountBefore - 1);
            }
        }

        private void ClearAllTables(ApplicationDbContext dbContext)
        {
            dbContext.Companies.RemoveRange(dbContext.Companies);
            dbContext.SaveChanges();
        }
    }
}
