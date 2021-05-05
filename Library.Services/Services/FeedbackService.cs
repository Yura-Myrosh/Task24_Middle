using Library.Interfaces;
using Library.Library.Services.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Library.Library.Services.Services
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IUnitOfWork _database;
        public FeedbackService(IUnitOfWork database)
        {
            _database = database;
        }
        public async Task CreateFeedbackAsync(Feedback feedback)
        {
            feedback.DateOfFeedback = DateTime.Now;
            await _database.FeedbackRepository.CreateFeedbackAsync(feedback);
        }

        public async Task<IEnumerable<Feedback>> GetAllFeedbacksAsync()
        {
            return await _database.FeedbackRepository.GetAllFeedbacksAsync();
        }
    }
}