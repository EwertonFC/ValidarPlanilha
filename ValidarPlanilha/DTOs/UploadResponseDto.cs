namespace ValidarPlanilha.DTOs;

public class UploadResponseDto
{
    public string NomeArquivo { get; set; }
    public long Tamanho { get; set; }
    public DateTime DataRecebimento { get; set; }

}
