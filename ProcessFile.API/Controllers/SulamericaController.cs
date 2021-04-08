using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class SulamericaController : ControllerBase
    {
        private readonly ISulamericaService _sulamericaService;

        public SulamericaController(ISulamericaService sulamericaService)
        {
            _sulamericaService = sulamericaService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var sulamerica = await _sulamericaService.GetAll();
            return Ok(sulamerica);
        }

        [HttpGet]
        [Route("all/{id}")]
        public async Task<IActionResult> FindAll(long id)
        {
            var sulamerica = await _sulamericaService.GetById(id);
            return Ok(sulamerica);
        }
    }
}
