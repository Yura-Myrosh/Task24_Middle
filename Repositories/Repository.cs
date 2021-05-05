using Library.Data;
using Library.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Library.Models;
using System.Data.Entity;

namespace Library.Repositories
{
    public class Repository <TEntity> : IRepository<TEntity>
        where TEntity : BaseEntity
    {
        public readonly LibraryContext _context;
        public Repository(LibraryContext context)
        {
            _context = context;
        }
        public virtual async Task CreateAsync(TEntity item)
        {
            _context.Set<TEntity>().Add(item);
            await SaveAsync();
        }

        public virtual async Task<TEntity> GetItemAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public virtual async void Delete(TEntity item)
        {
            _context.Set<TEntity>().Remove(item);
            await SaveAsync();
        }

        public virtual async Task DeleteByIdAsync(int id)
        {
            Delete(await GetItemAsync(id));
            await SaveAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> ListItemsAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity model)
        {
            var entity = _context.Set<TEntity>().Find(model.Id);

            if (entity == null)
            {
                return;
            }

            _context.Entry(entity).CurrentValues.SetValues(model);
            _context.Set<TEntity>().Attach(entity);
            await SaveAsync();
        }
    }
}
