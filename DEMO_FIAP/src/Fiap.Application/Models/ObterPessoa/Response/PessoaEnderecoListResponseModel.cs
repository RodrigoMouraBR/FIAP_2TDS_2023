namespace Fiap.Application.Models.ObterPessoa.Response
{
    public class PessoaEnderecoListResponseModel
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
    }
}
