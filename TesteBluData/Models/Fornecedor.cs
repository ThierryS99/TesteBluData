using System.ComponentModel.DataAnnotations.Schema;

namespace TesteBluData.Models
{
	public class Fornecedor
	{
		public string Nome { get; set; }
		public string CadastroId { get; set; } // CPF OU CNPJ   
		public string Telefone { get; set; }
		public string Rg { get; set; }
		public DateTime Nascimento { get; set; }
		public string Empresa { get; set; }
		public DateTime DataCadastro { get; set; }

		public Fornecedor() { }

		public Fornecedor(string empresa, string nome, string cadastroId, DateTime dataCadastro, string telefone, string rg, DateTime nascimento) // Caso seja CPF
		{
			Empresa = empresa;
			Nome = nome;
			CadastroId = cadastroId;
			Telefone = telefone;
			DataCadastro = dataCadastro;
			Telefone = telefone;
			Rg = rg;
			Nascimento = nascimento;
		}

		public Fornecedor(string empresa, string nome, string cadastroId, DateTime dataCadastro, string telefone) // Caso Seja CNPJ
		{
			Empresa = empresa;
			Nome = nome;
			CadastroId = cadastroId;
			Telefone = telefone;
			DataCadastro = dataCadastro;
			Telefone = telefone;
		}
	}
}
