using System.ComponentModel.DataAnnotations;

namespace Fiap.Application.Models.AdicionaPessoa.Request
{
    public class PessoaAddRequestModel
    {   
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string? Sobrenome { get; set; }

        [Display(Name = "Data Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string? CPF { get; set; }
       
        public string? RG { get; set; }

        public EnderecoAddRequestModel Endereco { get; set; }
    }
}
