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
            Eduart_Hajko_Task t1 = new Eduart_Hajko_Task();
           var val= t1.getvalue();

       
            ViewData["Rezultatet"] = val;

            return View();
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