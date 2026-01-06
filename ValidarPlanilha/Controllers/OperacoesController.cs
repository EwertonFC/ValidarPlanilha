using Microsoft.AspNetCore.Mvc;
using ValidarPlanilha.DTOs;

namespace ValidarPlanilha.Controllers
{

    [ApiController]
    [Route("api/operacoes")]
    public class OperacoesController : ControllerBase
    {
        
        private readonly UploadService _uploadService;

        public OperacoesController()
        {
            _uploadService = new UploadService();
        }
        
        [HttpPost("upload")]
        public IActionResult Upload(IFormFile arquivo)
        {
            if(arquivo == null)
            {
                return BadRequest(new
                {
                    mensagem = "Nenhum arquivo recebido"
                });
            }
            if(arquivo.Length == 0)
            {
                return BadRequest("Arquivo menor do que esperado");
            }

            var resposta = _uploadService.ProcessarUpload(arquivo);
            
            return Ok(resposta);

        }
    }
}
