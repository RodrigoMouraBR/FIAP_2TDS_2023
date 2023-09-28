using Fiap.Data.Context;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Data.Repositories
{
    public class PessoaRepository : IPessoaRepository
    {
        private readonly FiapContext _context;

        public PessoaRepository(FiapContext context)
        {
            _context = context;
        }

        public void AdicionarPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            _context.SaveChanges();
        }

        public void AtualizarPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Update(pessoa);
            _context.SaveChanges();
        }

        public void DeletePessoa(Guid id)
        {
            var pessoa = _context.Pessoas.Include(c => c.Endereco).SingleOrDefault();

            if (pessoa != null)
            {
                _context.Enderecos.Remove(pessoa.Endereco);
                _context.Pessoas.Remove(pessoa);
            }
           

            _context.SaveChanges();
        }

        public IEnumerable<Pessoa> ListarPessoa()
        {
            return _context.Pessoas.AsNoTracking()
                .Include(c => c.Endereco).ToList();
        }

        public Pessoa ObterPessoaPeloId(Guid id)
        {
            return _context.Pessoas.Find(id);
        }
    }
}
