namespace TesteBluData.Models
{
    public class FornecedorPJ
    {
        public Empresa Empresa { get; set; }
        public string Nome { get; set; }
        public string CadastroId { get; set; } // CPF OU CNPJ   
        public DateTime DataCadastro { get; set; }
        public string Telefone { get; set; }

        public FornecedorPJ() { }

        public FornecedorPJ(Empresa empresa, string nome, string cadastroId, DateTime dataCadastro, string telefone) // Caso Seja CNPJ
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
