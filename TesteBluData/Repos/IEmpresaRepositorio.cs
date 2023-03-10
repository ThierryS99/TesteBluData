using TesteBluData.Models;

namespace TesteBluData.Repos
{
	public interface IEmpresaRepositorio
	{
		List<Empresa> BuscarTodos();
		Empresa Adicionar(Empresa empresa);
	}
}
