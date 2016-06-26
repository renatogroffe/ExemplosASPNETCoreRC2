using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteJSONHelper.Models;

namespace TesteJSONHelper.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DadosBrasil =
                            new Pais()
                            {
                                Nome = "Brasil",
                                Continente = "América do Sul",
                                Capital = "Brasília",
                                CodigoTelefonico = "55"
                            };

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
