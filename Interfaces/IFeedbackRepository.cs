using Library.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        Task<IEnumerable<Feedback>> GetAllFeedbacksAsync();

        Task CreateFeedbackAsync(Feedback feedback);
    }
}
