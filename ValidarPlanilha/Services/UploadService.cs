using ValidarPlanilha.DTOs;

public class UploadService
{
    public UploadResponseDto ProcessarUpload(IFormFile arquivo) {
        
        var resposta = new UploadResponseDto
        {
            NomeArquivo = arquivo.FileName,
            DataRecebimento = DateTime.Now,
            Tamanho = arquivo.Length
        };
        return resposta;
    }
}