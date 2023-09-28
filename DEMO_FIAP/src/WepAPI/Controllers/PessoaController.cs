using Fiap.Application.Interfaces;
using Fiap.Application.Models.AdicionaPessoa.Request;
using Fiap.Application.Models.AtualizarPessoa.Request;
using Fiap.Application.Models.ObterPessoa.Response;
using Microsoft.AspNetCore.Mvc;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaApplicationService _pessoaApplicationService;

        public PessoaController(IPessoaApplicationService pessoaApplicationService)
        {
            _pessoaApplicationService = pessoaApplicationService;
        }

        [HttpGet]
        public ActionResult<List<PessoaEnderecoListResponseModel>> ListarPessoa()
        {
           var pessoas = _pessoaApplicationService.ListarPessoa();

            return Ok(pessoas);
        }



        [HttpPost("AdicionarPessoa")]
        public ActionResult AdicionarPessoa(PessoaAddRequestModel pessoaViewModel)
        {
            if (ModelState.IsValid)
                _pessoaApplicationService.AdicionarPessoa(pessoaViewModel);

            return Ok();
        }

        [HttpPut("EditarPessoa")]
        public ActionResult EditarProduto(PessoaAtualizaRequestModel pessoaAtualizaRequestModel)
        {
            if (ModelState.IsValid)
                _pessoaApplicationService.AtualizarPessoa(pessoaAtualizaRequestModel);

            return Ok();
        }

        [HttpDelete]
        public ActionResult DeletePessoa(Guid id)
        {
            _pessoaApplicationService.DeletePessoa(id);

            return Ok();
        }
    }
}
