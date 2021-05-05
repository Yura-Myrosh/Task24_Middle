using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IRepository<T> 
        where T: BaseEntity
    {
        Task<IEnumerable<T>> ListItemsAsync();

        Task<T> GetItemAsync(int id);

        Task CreateAsync(T item);

        void Delete(T item);

        Task DeleteByIdAsync(int id);

        Task Update(T model);

        Task SaveAsync();
    }
}
