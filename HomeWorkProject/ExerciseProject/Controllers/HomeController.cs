using ExerciseProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExerciseProject.Services;
using System.Text;
using System.Linq;

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

            // exercise 1

            /*int sum = 0;
            StringBuilder s = new StringBuilder();
            for (int i = 0; i <= 500; i++)
            {
                if (i % 3 != 0)
                {
                    sum += i;
                    s.Append(i + ",");
                }

            }

            return Json(s.ToString() + " dhe shuma eshte: " + sum);*/

            //exercise 2 - HOMEWORK

            StringBuilder elements = new StringBuilder();
            StringBuilder reversedElements = new StringBuilder();

            Random r = new Random();
            int arrSize = r.Next(0, 100);

            int[] arr = new int[arrSize];

            for (int i = 0; i <= arrSize; i++)
            {
                Random r2 = new Random();
                int arrElement = r2.Next(0, arrSize);

                elements.Append(arrElement + ",");

            }

            for (int i = elements.Length - 1; i >= 0; i--)
            {
                reversedElements.Append(elements[i]);
            }


            return Json("The random selected elements (" + arrSize + ") of the array are: " + elements.ToString() + " and the elements of the array in reversed order are: " + reversedElements.ToString());
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