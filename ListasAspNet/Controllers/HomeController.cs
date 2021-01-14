using ListasAspNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ListasAspNet.Controllers
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
            ViewData["Cabecalho"] = "Exemplo usagem de múltiplos modelos";


            List<Pessoa> lstPessoas = new List<Pessoa>();

            lstPessoas.Add(new Pessoa { Nome = "Milena" });
            lstPessoas.Add(new Pessoa { Nome = "Pedro" });
            lstPessoas.Add(new Pessoa { Nome = "Guilherme" });
            lstPessoas.Add(new Pessoa { Nome = "Daniel" });

            List<Time> lstTimes = new List<Time>();

            lstTimes.Add(new Time { Descricao = "Corinthians" });
            lstTimes.Add(new Time { Descricao = "Palmeiras" });
            lstTimes.Add(new Time { Descricao = "São Paulo" });
            lstTimes.Add(new Time { Descricao = "Santos" });

            PessoaTime _pessoaTimes = new PessoaTime();

            _pessoaTimes.lstPessoas = lstPessoas;
            _pessoaTimes.lstTimes = lstTimes;

            return View(_pessoaTimes);
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
