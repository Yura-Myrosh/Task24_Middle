using System;
using System.Threading.Tasks;

namespace Library.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IArticleRepository ArticleRepository { get; }
        IFeedbackRepository FeedbackRepository { get; }

        IQuestionnaireRepository QuestionnaireRepository { get; }
        //Add more repositories

        Task SaveAsync();
    }
}
