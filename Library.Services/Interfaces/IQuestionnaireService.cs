using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Library.Services.Interfaces
{
    public interface IQuestionnaireService
    {
        Task<Questionnaire> GetQuestionnaireAsync(int id = 1);
        Task SaveAnswAsync (Questionnaire model);
    }
}
