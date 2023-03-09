using System.ComponentModel.DataAnnotations.Schema;

namespace TesteBluData.Models
{
    [Table("FornecedorPf")]

    public class FornecedorPf
    {
        [Column("")]

        public Empresa Empresa { get; set; }
        public string Nome { get; set; }
        public string CadastroId { get; set; } // CPF OU CNPJ   
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }
        public string Rg { get; set; }
        public DateTime Nascimento { get; set; }

        public FornecedorPf() { }

        public FornecedorPf(Empresa empresa, string nome, string cadastroId, DateTime dataCadastro, string telefone, string rg, DateTime nascimento) // Caso seja CPF
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
    }
}
