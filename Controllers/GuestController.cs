using Library.Interfaces;
using Library.Library.Services.Interfaces;
using Library.Models;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Library.Controllers
{
    public class GuestController : Controller
    {
        private readonly IFeedbackService _feedbackService;

        public GuestController(IFeedbackService feedbackService)
        {
            _feedbackService = feedbackService;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _feedbackService.GetAllFeedbacksAsync());
        }

        [HttpGet]
        public ActionResult ShowCreateFeedbackForm()
        {
            return View("CreateFeedback");
        }

        [HttpPost]
        public async Task<ActionResult> CreateFeedback(Feedback feedback)
        {
            await _feedbackService.CreateFeedbackAsync(feedback);
            return RedirectToAction("Index", "Guest");
        }
    }
}