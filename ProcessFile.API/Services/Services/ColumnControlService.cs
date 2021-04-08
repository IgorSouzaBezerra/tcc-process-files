using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class ColumnControlService : IColumnControlService
    {
        private readonly IColumnControlRepository _columnControlRepository;

        public ColumnControlService(IColumnControlRepository columnControlRepository)
        {
            _columnControlRepository = columnControlRepository;
        }

        public async Task<ColumnControl> Create(ColumnControl columnControl)
        {
            var columnCreate = await _columnControlRepository.Create(columnControl);
            return columnCreate;
        }

        public async Task<ColumnControl> Get(long id)
        {
            return await _columnControlRepository.Get(id);
        }

        public async Task<List<ColumnControl>> Get()
        {
            return await _columnControlRepository.Get();
        }

        public async Task Remove(long id)
        {
            await _columnControlRepository.Remove(id);
        }

        public async Task<ColumnControl> Update(ColumnControl columnControl)
        {
            var columnUpdate = await _columnControlRepository.Update(columnControl);
            return columnUpdate;
        }

        public async Task<List<ColumnControl>> FindByCompany(string company)
        {
            var control = await _columnControlRepository.FindByCompany(company);
            return control;
        }

        public async Task<List<string>> GetCompanies()
        {
            var companies = await _columnControlRepository.GetCompanies();
            return companies;
        }
    }
}
