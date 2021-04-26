using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobEventController : ControllerBase
    {
        private readonly IJobEventService _jobService;

        public JobEventController(IJobEventService jobService)
        {
            _jobService = jobService;
        }

        [HttpPost]
        public async Task<IActionResult> Create()
        {
            var job = await _jobService.Create();
            return Ok(job);
        }

        [HttpPost]
        [Route("{id}")]
        public async Task<IActionResult> Update(long id)
        {
            var job = await _jobService.CompleteJob(id);
            return Ok(job);
        }

        [HttpGet("{page}")]
        public async Task<IActionResult> GetAll(int page)
        {
            var jobs = await _jobService.GetAll(page);
            return Ok(jobs);
        }

        [HttpGet]
        [Route("getQtdJob")]
        public async Task<IActionResult> GetQtdJob()
        {
            var jobs = await _jobService.GetQtdJob();
            return Ok(jobs);
        }
    }
}
