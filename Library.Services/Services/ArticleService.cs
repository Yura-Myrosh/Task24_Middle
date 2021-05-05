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
    public class ArticleService  : IArticleService
    {
        private readonly IUnitOfWork _database;

        public ArticleService(IUnitOfWork unitOfWork)
        {
            _database = unitOfWork;
        }

        public async Task<IEnumerable<Article>> GetAllArticles()
        {
            return await _database.ArticleRepository.GetAllArticles();
        }

        //add more service actions

    }
}