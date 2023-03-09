namespace TesteBluData.Models
{
    public class Empresa
    {
        public string Uf { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }

        public Empresa() { }

        public Empresa(string uf, string nomeFantasia, string cnpj)
        {
            Uf = uf;
            NomeFantasia = nomeFantasia;
            Cnpj = cnpj;
        }
    }
}
