using System.Collections.Generic;
using System.Linq;
using app.domain;
using Microsoft.EntityFrameworkCore;
using app.domain.Services;
using app.domain.artiste;

namespace app.persistence
{
    public class ArtistFrameworkRepository<T> : IArtistRepository<T> where T : Artiste
    {
            private readonly DbContext _context;

            public ArtistFrameworkRepository(ApplicationDbContext dbContext)
            {
                _context = dbContext;
            }

            public IEnumerable<T> GetAll()
            {
                return _context.Set<T>().ToList();
            }

            public T GetById(int id)
            {
                return _context.Set<T>().FirstOrDefault(x => x.ID_ARTISTE == id);
            }

            public void Delete(T entity) // suppression
        {
                _context.Set<T>().Remove(entity);
                _context.SaveChanges();
            }

            public void Add(T entity) // Insertion
        {
                _context.Set<T>().Add(entity);
                _context.SaveChanges();
            }

            public void Update(T entity) // mise-à-jour
        {
                _context.Set<T>().Update(entity);
                _context.SaveChanges();
            }

        public void Cascade(T entity) // mise-à-jour
        {
            //
        }
    }
}