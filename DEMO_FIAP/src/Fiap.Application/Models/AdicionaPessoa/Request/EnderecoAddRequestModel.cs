namespace Fiap.Application.Models.AdicionaPessoa.Request
{
    public class EnderecoAddRequestModel
    {       
        public string Descricao { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
