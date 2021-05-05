using System.Threading.Tasks;
using System.Web.Mvc;
using Library.Library.Services.Services;
using Library.Library.Services.Interfaces;
using Library.Models;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly IQuestionnaireService _questionService;
        public QuestionnaireController(IQuestionnaireService questionService)
        {
            _questionService = questionService;
        }

        [HttpGet]
        public async Task<ActionResult> Questionnaire()
        {
            return View("Questionnaire", await _questionService.GetQuestionnaireAsync());
        }

        [HttpPost]
        public async Task<RedirectToRouteResult> Questionnaire(Questionnaire questionnaire)
        {
            await _questionService.SaveAnswAsync(questionnaire);
            return RedirectToAction("Index", "Home");
        }
    }
}