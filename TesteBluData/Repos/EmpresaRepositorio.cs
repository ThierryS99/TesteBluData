using TesteBluData.Data;
using TesteBluData.Models;

namespace TesteBluData.Repos
{
	public class EmpresaRepositorio : IEmpresaRepositorio
	{
		private readonly BancoContext _bancoContext;

		public EmpresaRepositorio(BancoContext bancoContext)
		{
			_bancoContext = bancoContext;
		}

        public List<Empresa> BuscarTodos()
        {
			return _bancoContext.Empresa.ToList();
        }

        public Empresa Adicionar(Empresa empresa)
		{
			_bancoContext.Empresa.Add(empresa);
			_bancoContext.SaveChanges();
			return empresa;
		}
    }
}
