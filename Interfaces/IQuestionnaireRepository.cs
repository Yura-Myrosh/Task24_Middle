using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IQuestionnaireRepository : IRepository<Questionnaire>
    {
        Task<Questionnaire> GetQuestionnaireAsync(int id = 1);
    }
}
