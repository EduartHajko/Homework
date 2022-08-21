using ExerciseProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExerciseProject.Services;

namespace ExerciseProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        
        public IActionResult Index(string Value)
        { 
            test t1 = new test();
           var val= t1.getvalue();

            string s1 = Value;
            var model = new SendMessageModel()
            {
                Id = 1,
                Name = "rehigreogreoigerogjreogerjg"
            };
            model.Name = "muksi9";
            ViewData["Rezultatet"] = "Rezultatet e ushtrimeve";
            return View(model);
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