using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using NoteBook.DataService.Data;
using NoteBook.DataService.IRepository;

namespace NoteBook.DataService.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T: class
    {
        protected readonly AppDbContext _context;
        protected readonly ILogger _logger;
        internal DbSet<T> dbset;
        private AppDbContext context;

        public GenericRepository(AppDbContext context,
                                 ILogger logger)
        {
            _context=context;
            _logger=logger; 
            dbset=context.Set<T>();
        }
        public virtual async Task<bool> Add(T entity)
        {
            await dbset.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            return await dbset.ToListAsync();
        }

        public virtual async Task<bool> Delete(Guid id, string userId)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(Guid id)
        {
            return await dbset.FindAsync(id);
        }

        public Task<bool> Upsert(T entity)
        {
            throw new NotImplementedException();
        }
    }
}