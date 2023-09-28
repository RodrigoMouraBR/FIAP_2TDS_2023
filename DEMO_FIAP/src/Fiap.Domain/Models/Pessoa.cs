using Fiap.Domain.Interfaces;

namespace Fiap.Domain.Models
{
    public class Pessoa : Entity, IAgregateRoot
    {
        public Pessoa(string nome, string sobrenome, DateTime dataNascimento, string cPF, string rG)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            CPF = cPF;
            RG = rG;
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }

        public Endereco Endereco { get; private set; }

        //AddRoc
        public void SetId()
        {
            Id = Guid.NewGuid();
        }

        public void RelacionaEndereco()
        {
            Endereco.RelacionaEnderecoPessoa(Id);
        }
    }
}
