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


        [HttpGet]
        public IActionResult GetValueFromPostman(string parameter)
        {

             static void Main()
            {
                Console.WriteLine("\nSum of the first 500 prime numbers: ");
                long sum = 0;
                int ctr = 0;
                int n = 2;
                while (ctr < 500)
                {
                    if (isPrime(n))
                    {
                        sum += n;
                        ctr++;
                    }
                    n++;
                }

                Console.WriteLine(sum.ToString());

            }
             static bool isPrime(int n)
            {
                int x = (int)Math.Floor(Math.Sqrt(n));

                if (n == 1) return false;
                if (n == 2) return true;

                for (int i = 2; i <= x; ++i)
                {
                    if (n % i == 0) return false;
                }

                return true;
            }
        }
    }


     
    }
