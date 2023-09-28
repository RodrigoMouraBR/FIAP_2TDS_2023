using Fiap.Domain.FluentValidation;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;

namespace Fiap.Domain.Service
{
    public class PessoaService : BaseService, IPessoaService
    {
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IPessoaRepository pessoaRepository)
        {
            _pessoaRepository = pessoaRepository;
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            if (!Validate(new PessoaValidation(), pessoa))
            {
                return;
            }  

            pessoa.SetId();

            pessoa.RelacionaEndereco();

            _pessoaRepository.AdicionarPessoa(pessoa);
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            _pessoaRepository.AtualizarPessoa(pessoa);
        }

        public void DeletePessoa(Guid id)
        {
            _pessoaRepository.DeletePessoa(id);
        }

        public IEnumerable<Pessoa> ListarPessoa()
        {
            return _pessoaRepository.ListarPessoa();
        }

        public Pessoa ObterPessoaPeloId(Guid id)
        {
            return _pessoaRepository.ObterPessoaPeloId(id);
        }
    }
}
