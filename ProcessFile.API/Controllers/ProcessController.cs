using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Domain.Enum;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ProcessController : ControllerBase
    {
        private readonly IProcessService _processService;

        public ProcessController(IProcessService processService)
        {
            _processService = processService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var process = await _processService.Get();
            return Ok(process);
        }

        [HttpGet]
        [Route("getPending")]
        public async Task<IActionResult> GetPending()
        {
            var process = await _processService.GetPending();
            return Ok(process);
        }

        [HttpGet]
        [Route("getFinished")]
        public async Task<IActionResult> GetFinished()
        {
            var process = await _processService.GetFinished();
            return Ok(process);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetRelations(long id)
        {
            var process = await _processService.FindProcess(id);
            return Ok(process);
        }

        [HttpPost]
        [Route("AlterStatus/{id}")]
        public async Task<IActionResult> FinishProcess(long id)
        {
            var process = await _processService.Get(id);

            var processUpdated = await _processService.UpdateStatus(process);
            return Ok(processUpdated);
        }
    }
}
