using AutoMapper;
using Fiap.Application.Interfaces;
using Fiap.Application.Models.AdicionaPessoa.Request;
using Fiap.Application.Models.AtualizarPessoa.Request;
using Fiap.Application.Models.ObterPessoa.Response;
using Fiap.Domain.Interfaces;
using Fiap.Domain.Models;

namespace Fiap.Application.Services
{
    public class PessoaApplicationService : IPessoaApplicationService
    {
        private readonly IPessoaService _pessoaService;
        private readonly IPessoaRepository _pessoaRepository;
        private readonly IMapper _mapper;
        public PessoaApplicationService(IPessoaService pessoaService, IPessoaRepository pessoaRepository, IMapper mapper)
        {
            _pessoaService = pessoaService;
            _mapper = mapper;
            _pessoaRepository = pessoaRepository;
        }

        public void AdicionarPessoa(PessoaAddRequestModel pessoaAddRequestModel)
        {
            //Exemplo 1
            //var pessoa = new Pessoa(pessoaAddRequestModel.Nome,
            //                        pessoaAddRequestModel.Sobrenome,
            //                        pessoaAddRequestModel.DataNascimento,
            //                        pessoaAddRequestModel.CPF,
            //                        pessoaAddRequestModel.RG);



            //Exemplo 2 com AutoMapper
            var pessoa = _mapper.Map<Pessoa>(pessoaAddRequestModel);

            _pessoaService.AdicionarPessoa(pessoa);
        }

        public void AtualizarPessoa(PessoaAtualizaRequestModel pessoaAtualizaRequestModel)
        {

            var pessoa = _mapper.Map<Pessoa>(pessoaAtualizaRequestModel);
            _pessoaService.AtualizarPessoa(pessoa);
        }

        public void DeletePessoa(Guid id)
        {
            _pessoaService.DeletePessoa(id);
        }

        public IEnumerable<PessoaEnderecoListResponseModel> ListarPessoa()
        {
            return _mapper.Map<IEnumerable<PessoaEnderecoListResponseModel>>(_pessoaRepository.ListarPessoa());
        }
    }
}
