using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TesteBluData.Models;

namespace TesteBluData.Controllers
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

        public IActionResult CadastroFornecedor()
        {
            return View();
        }

        public IActionResult CadastroEmpresa()
        {
            return View();
        }

        public IActionResult ConsultaFornecedor()
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