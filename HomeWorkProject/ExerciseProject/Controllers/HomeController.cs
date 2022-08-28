using ExerciseProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExerciseProject.Services;
using System.Text;

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

            ViewData["Console"] = "Rezultati i Ushtrimit";
            ViewData["Rezultatet"] = val;

            return View();
        }

        [HttpGet]
        public IActionResult GetValueFromPostman(string parameter)
        {
            {
                int sum = 0;
                StringBuilder s = new StringBuilder();
                for (int i = 0; i <= 10; i++)
                {
                    if (i % 3 != 0)
                    {
                        sum += i;
                        s.Append(i + ",");
                    }
                }
                return Json(s.ToString() + " dhe shuma eshte: " + sum);
            }

            return Json("edi");
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