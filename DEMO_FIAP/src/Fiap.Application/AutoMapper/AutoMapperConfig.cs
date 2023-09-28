using AutoMapper;
using Fiap.Application.Models.AdicionaPessoa.Request;
using Fiap.Application.Models.AdicionaPessoa.Response;
using Fiap.Application.Models.AtualizarPessoa.Request;
using Fiap.Application.Models.ObterPessoa.Response;
using Fiap.Domain.Models;

namespace Fiap.Application.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Pessoa, PessoaAddRequestModel>().ReverseMap();
            CreateMap<Endereco, EnderecoAddRequestModel>().ReverseMap();

            CreateMap<Pessoa, PessoaAddResponseModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.PessoaId));

            CreateMap<Endereco, EnderecoAddResponseModel>().ReverseMap()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(s => s.EnderecoId));

            CreateMap<Pessoa, PessoaAtualizaRequestModel>().ReverseMap();
            CreateMap<Pessoa, PessoaEnderecoListResponseModel>().ReverseMap();            
        }
    }
}
