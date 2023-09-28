using System.ComponentModel.Design;

namespace Fiap.Domain.Models
{
    public class Endereco : Entity
    {
        public Endereco(string descricao, 
                        string cEP, 
                        string bairro, 
                        string cidade, 
                        string uF)
        {
            Descricao = descricao;
            CEP = cEP;
            Bairro = bairro;
            Cidade = cidade;
            UF = uF;
        }

        public Guid Id { get; private set; }
        public string Descricao { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public Guid PessoaId { get; private set; }
        public Pessoa Pessoa { get; private set; }

        internal void RelacionaEnderecoPessoa(Guid pessoaId)
        {
            Id = Guid.NewGuid();
            PessoaId = pessoaId;
        }
    }
}
