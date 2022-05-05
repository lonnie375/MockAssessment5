using Microsoft.AspNetCore.Mvc;
using MockAssessment5b.Models;
using System.Diagnostics;

namespace MockAssessment5b.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult GetAge()
        {
            return View();
        }

        //Anytime you're sending data it is going to be a post
        [HttpPost]
        public IActionResult Result(Person person)
        {
            if (person.Age >= 21)
            {
                person.CanDrink = true;
            }

            if (person.Age >= 16)
            {
                person.CanDrive = true;
            }
            return View(person); 
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}