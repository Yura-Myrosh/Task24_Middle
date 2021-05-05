using Library.Interfaces;
using Library.Library.Services.Interfaces;
using Library.Library.Services.Services;
using Library.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Library
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<IArticleService, ArticleService>();
            container.RegisterType<IFeedbackService, FeedbackService>();
            container.RegisterType<IQuestionnaireService, QuestionnaireService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}