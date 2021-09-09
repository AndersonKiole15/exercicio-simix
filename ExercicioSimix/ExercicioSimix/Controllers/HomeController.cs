using ExercicioSimix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioSimix.Controllers
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

        public IActionResult ShowNumbers()
        {
            string[] resultado = new string[200];

            for (int i = 1; i < 201; i++)
            {
                
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    resultado[i - 1] = "Z";
                }
                else
                if (i % 3 == 0)
                {
                    resultado[i - 1] = "X";
                }
                else
                if (i % 5 == 0)
                {
                    resultado[i - 1] = "Y";
                }
                else
                {
                    resultado[i - 1] = i + "";
                }
            }

            ViewBag.Numeros = resultado;

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
