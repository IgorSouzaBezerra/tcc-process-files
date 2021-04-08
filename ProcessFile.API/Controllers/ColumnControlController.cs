using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Services.Interfaces;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class ColumnControlController : ControllerBase
    {
        private readonly IColumnControlService _columnControlService;
        public ColumnControlController(IColumnControlService columnControlService)
        {
            _columnControlService = columnControlService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var all =  await _columnControlService.Get();
            return Ok(all);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get(long id)
        {
            var control = await _columnControlService.Get(id);
            return Ok(control);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ColumnControl columnControl)
        {
            var control = await _columnControlService.Create(columnControl);
            return Ok(control);
        }

        [HttpDelete]
        public async Task Remove(int id)
        {
            await _columnControlService.Remove(id);
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] ColumnControl columnControl)
        {
            var entity = await _columnControlService.Update(columnControl);
            return Ok(entity);
        }

        [HttpGet]
        [Route("get-company")]
        public async Task<IActionResult> Get([FromQuery] string company)
        {
            var controlCompany = await _columnControlService.FindByCompany(company);
            return Ok(controlCompany);
        }

        [HttpGet]
        [Route("companies")]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _columnControlService.GetCompanies();
            return Ok(companies);
        }
    }
}
