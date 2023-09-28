using Fiap.Application.Models.AdicionaPessoa.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Application.Models.AdicionaPessoa.Response
{
    public class PessoaAddResponseModel
    {
        public Guid PessoaId { get; set; }
        public string Nome { get; set; }        
        public string Sobrenome { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }       
        public string CPF { get; set; }
        public string RG { get; set; }

        public EnderecoAddResponseModel Endereco { get; set; }
    }
}
