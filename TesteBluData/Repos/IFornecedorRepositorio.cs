using TesteBluData.Models;

namespace TesteBluData.Repos
{
	public interface IFornecedorRepositorio
	{
        List<Fornecedor> BuscarTodos();
        Fornecedor Adicionar(Fornecedor fornecedor);
	}
}
