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
    public class QuestionnaireService : IQuestionnaireService
    {
        private readonly IUnitOfWork _database;

        public QuestionnaireService(IUnitOfWork database)
        {
            _database = database;
        }

        public async Task<Questionnaire> GetQuestionnaireAsync(int id = 1)
        {
            return await _database.QuestionnaireRepository.GetQuestionnaireAsync(id);
        }

        public async Task SaveAnswAsync (Questionnaire model)
        {
            await _database.QuestionnaireRepository.Update(model);
        }
    }
}