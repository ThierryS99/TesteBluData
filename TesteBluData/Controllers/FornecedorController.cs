using Microsoft.AspNetCore.Mvc;
using TesteBluData.Models;
using TesteBluData.Repos;

namespace TesteBluData.Controllers
{
    public class FornecedorController : Controller
    {
		private readonly IFornecedorRepositorio _fornecedorRepositorio;

		
		public FornecedorController(IFornecedorRepositorio fornecedorRepositorio)
		{
			_fornecedorRepositorio = fornecedorRepositorio;
		}
		
        public IActionResult Index()
        {
            List<Fornecedor> fornecedor = _fornecedorRepositorio.BuscarTodos();
            return View(fornecedor);
        }

        public IActionResult ConsultaFornecedor()
        {
            List<Fornecedor> fornecedor = _fornecedorRepositorio.BuscarTodos();
            return View(fornecedor);
        }
        

        public IActionResult Home()
        {
            List<Fornecedor> fornecedor = _fornecedorRepositorio.BuscarTodos();
            return View(fornecedor);
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
		public IActionResult Cadastrar(Fornecedor fornecedor)
		{
			_fornecedorRepositorio.Adicionar(fornecedor);
			return RedirectToAction("Index");
		}
    }
}
