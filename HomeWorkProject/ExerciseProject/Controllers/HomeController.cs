﻿using ExerciseProject.Models;
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
        //task 8 return from postman sum of numbers
        [HttpGet]
        public IActionResult GetValueFromPostman(string edi )
        {

            //detyr e shtepise kthe listen reverse 
           List<int> list = new List<int>();
            StringBuilder st = new StringBuilder();     
            int[] array = new int[] { 1, 3, 5, 7, 9 };


            for (int i = array.Length - 1; i >= 0; i--)
            {
                list.Add(array[i]);
            }
            foreach  (var a in list)
            {
                st.Append(a.ToString()+ " , ");
            }

            return Json("lista e arrayt reverse "+ st.ToString());
        }

        //task 17
        [HttpGet]
        public IActionResult GetValuedublicate(string input , int edi)
        {

           
            string[] inputs = input.Split(' ');
            StringBuilder sb = new StringBuilder();
            foreach (string word in inputs)
            {
                sb.Append($"{word} ");
                sb.Append($"{word} ");
            }
            
            return Json(sb.ToString());
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