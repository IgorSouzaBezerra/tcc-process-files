using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UnimedController : ControllerBase
    {
        private readonly IUnimedService _unimedService;

        public UnimedController(IUnimedService unimedService)
        {
            _unimedService = unimedService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var unimed = await _unimedService.Get();
            return Ok(unimed);
        }
    }
}
