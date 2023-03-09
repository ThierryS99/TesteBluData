using Microsoft.EntityFrameworkCore;
using TesteBluData.Models;

namespace TesteBluData.Data
{
	public class BancoContext : DbContext
	{
		public BancoContext(DbContextOptions<BancoContext> options) : base(options)
		{

		}

		public DbSet<Empresa> Empresa { get; set; }
		public DbSet<Fornecedor> FornecedorPf { get; set; }
	}
}
