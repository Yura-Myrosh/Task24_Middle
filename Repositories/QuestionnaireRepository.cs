using Library.Data;
using Library.Interfaces;
using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Library.Repositories
{
    public class QuestionnaireRepository : Repository<Questionnaire>, IQuestionnaireRepository
    {
        public QuestionnaireRepository(LibraryContext context) : base(context)
        {

        }
        public Task<Questionnaire> GetQuestionnaireAsync(int id = 1)
        {
            return GetItemAsync(id);
        }
    }
}