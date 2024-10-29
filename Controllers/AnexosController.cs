using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using atendecidadao.Models;
using atendecidadao.Services;

namespace atendecidadao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnexosController : BaseController<Anexo, IAnexoService>
    {
        private readonly string _storagePath;

        public AnexosController(IAnexoService service) : base(service)
        {
            // Configurando o caminho onde os arquivos serão salvos
            _storagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

            // Verifica se o diretório de upload existe, caso contrário, cria-o
            if (!Directory.Exists(_storagePath))
                Directory.CreateDirectory(_storagePath);
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Nenhum arquivo foi selecionado para upload.");

            // Valida o tipo de arquivo para permitir apenas imagens
            if (!file.ContentType.StartsWith("image/")) 
            {
                return BadRequest("Apenas arquivos de imagem são permitidos.");
            }

            // Define o caminho completo onde o arquivo será salvo
            var filePath = Path.Combine(_storagePath, file.FileName);

            // Salva o arquivo no diretório
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Retorna a URL do arquivo para ser usado pelo frontend
            var fileUrl = $"/uploads/{file.FileName}";
            return Ok(new { FilePath = fileUrl });
        }
    }
}
