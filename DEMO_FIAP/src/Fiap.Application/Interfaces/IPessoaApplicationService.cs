using Fiap.Application.Models.AdicionaPessoa.Request;
using Fiap.Application.Models.AtualizarPessoa.Request;
using Fiap.Application.Models.ObterPessoa.Response;
using Fiap.Domain.Models;

namespace Fiap.Application.Interfaces
{
    public interface IPessoaApplicationService
    {
        void AdicionarPessoa(PessoaAddRequestModel pessoaViewModel);

        void AtualizarPessoa(PessoaAtualizaRequestModel pessoaAtualizaRequestModel);

        void DeletePessoa(Guid id);

       
        IEnumerable<PessoaEnderecoListResponseModel> ListarPessoa();
    }
}
