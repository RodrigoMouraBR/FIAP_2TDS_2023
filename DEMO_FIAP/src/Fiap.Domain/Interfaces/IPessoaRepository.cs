using Fiap.Domain.Models;

namespace Fiap.Domain.Interfaces
{
    public interface IPessoaRepository
    {
        void AdicionarPessoa(Pessoa pessoa);

        void AtualizarPessoa(Pessoa pessoa);

        void DeletePessoa(Guid id);

        Pessoa ObterPessoaPeloId(Guid id);

        IEnumerable<Pessoa> ListarPessoa();
    }
}
