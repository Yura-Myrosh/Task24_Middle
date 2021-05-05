using Library.Data;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext _context;
        private IArticleRepository _articleRepository;
        private IFeedbackRepository _feedbackRepository;
        private IQuestionnaireRepository _questionRepository;

        public UnitOfWork(LibraryContext context)
        {
            _context = context;
        }

        public IArticleRepository ArticleRepository 
        { 
            get 
            {
                if (_articleRepository == null)
                {
                    _articleRepository = new ArticleRepository(_context);
                }
                return _articleRepository;
            } 
        }

        public IFeedbackRepository FeedbackRepository
        {
            get
            {
                if (_feedbackRepository == null)
                {
                    _feedbackRepository = new FeedbackRepository(_context);
                }
                return _feedbackRepository;
            }
        }

        public IQuestionnaireRepository QuestionnaireRepository 
        {
            get
            {
                if (_questionRepository == null)
                {
                    _questionRepository = new QuestionnaireRepository(_context);
                }

                return _questionRepository;
            }
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
