using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFiles.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public async Task<IActionResult> Get([FromQuery] string filename, string subject)
        {
            var retorno = await _fileService.ReadFile(filename, subject);
            return Ok(retorno);
        }
    }
}
