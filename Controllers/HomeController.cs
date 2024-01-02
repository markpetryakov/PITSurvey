using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PITSurvey.Data;
using PITSurvey.Models;
using System.Diagnostics;
using System.Linq;

namespace PITSurvey.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.CurrentDate = DateTime.Now.ToString("MMMM dd, yyyy");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(SurveyAnswers surveyAnswer)
        {
            return View(surveyAnswer);
        }


        [HttpPost]
        public IActionResult CheckEligibility(ConsentForm model)
        {
            // Check eligibility based on user's answers
            if (model.SurveyAnswer == "Yes")
            {
                // If the user answered "Yes" to question A, redirect to Ineligible
                return View("Ineligible");
            }
            else if (model.AgreeToConsent == "No")
            {
                // If the user answered "No" to question B, redirect to Ineligible
                return View("Ineligible");
            }
            else if (IsIneligibleLocation(model.StayingLocation))
            {
                // If the location is ineligible, redirect to Ineligible
                return View("Ineligible");
            }
            else if (model.SurveyAnswer == "No" && model.AgreeToConsent == "Yes")
            {
                // Redirect to Part2 view if the user answered correctly
                return RedirectToAction("Part2");
            }
            else
            {
                // Display a message or handle other conditions
                return View("Ineligible");
            }
        }

        private bool IsIneligibleLocation(string stayingLocation)
        {
            // List of eligible options for question C
            var eligibleOptions = new List<string> { "H", "I", "J", "K", "L", "M", "N" };

            // Convert the input to uppercase for case-insensitive comparison
            stayingLocation = stayingLocation?.Trim().ToUpper();

            // Check if the user selected an eligible option
            return !eligibleOptions.Contains(stayingLocation);
        }






        // second page of survey
        public ActionResult Part2()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Part2(SurveyAnswers answers)
        {

            _context.SurveyAnswers.Add(answers);
            _context.SaveChanges();

            return View("endPage");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
