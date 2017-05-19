using System.Collections.Generic;
using System.Linq;
using app.domain;
using Microsoft.EntityFrameworkCore;
using app.domain.Services;
using app.domain.client;

namespace app.persistence
{
    public class ClientFrameworkRepository<T> : IClientRepository<T> where T : Client
    {
            private readonly DbContext _context;

            public ClientFrameworkRepository(ApplicationDbContext dbContext)
            {
                _context = dbContext;
            }

            public IEnumerable<T> GetAll()
            {
                return _context.Set<T>().ToList();
            }

            public T GetById(int id)
            {
                return _context.Set<T>().FirstOrDefault(x => x.ID_CLIENT == id);
            }

            public void Delete(T entity)
            {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }

            public void Add(T entity)
            {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }

            public void Update(T entity)
            {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            }
            public void Cascade(T entity) // opérations en cascade
        {
                //
            }
    }
}