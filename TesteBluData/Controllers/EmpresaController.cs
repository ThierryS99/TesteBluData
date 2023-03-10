using Microsoft.AspNetCore.Mvc;
using TesteBluData.Models;
using TesteBluData.Repos;

namespace TesteBluData.Controllers
{
    public class EmpresaController : Controller
    {
		private readonly IEmpresaRepositorio _empresaRepositorio;
        public EmpresaController(IEmpresaRepositorio empresaRepositorio)
        {
            _empresaRepositorio = empresaRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }

		public IActionResult Cadastrar()
		{
			return View();
		}

		public IActionResult Editar()
		{
			return View();
		}

		public IActionResult Apagar()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Cadastrar(Empresa empresa)
		{
			_empresaRepositorio.Adicionar(empresa);
			return RedirectToAction("Index");
		}
	}
}
