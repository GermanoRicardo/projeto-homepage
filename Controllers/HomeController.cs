using ENTREVISTA_EMPREGARE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ENTREVISTA_EMPREGARE.Controllers
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
            var listaVagas = new List<Vaga>();

            for (int i = 0; i < 8; i++)
            {
                listaVagas.Add(new Vaga()
                {
                    Titulo = "Vendedor Externo",
                    Localizacao = "São José do Rio Preto",
                    Salario = 2000
                });
            }

            return View(listaVagas);
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
