using Microsoft.AspNetCore.Mvc;

namespace ValidarPlanilha.Controllers
{

    [ApiController]
    [Route("api/operacoes")]
    public class OperacoesController : ControllerBase
    {
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
            return Ok(new 
            {
                dataRecebimento = DateTime.UtcNow,
                nomeArquivo = arquivo.FileName,
                tamanho = arquivo.Length
            });
        }
    }
}
