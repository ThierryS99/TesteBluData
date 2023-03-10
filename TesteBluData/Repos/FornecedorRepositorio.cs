using TesteBluData.Data;
using TesteBluData.Models;

namespace TesteBluData.Repos
{
	public class FornecedorRepositorio : IFornecedorRepositorio
	{
		private readonly BancoContext _bancoContext;

		public FornecedorRepositorio(BancoContext bancoContext)
		{
			_bancoContext = bancoContext;
		}

        public List<Fornecedor> BuscarTodos()
        {
            return _bancoContext.Fornecedor.ToList();
        }

        public Fornecedor Adicionar(Fornecedor fornecedor)
		{
			_bancoContext.Add(fornecedor);
			_bancoContext.SaveChanges();
			return fornecedor;
		}
    }
}
