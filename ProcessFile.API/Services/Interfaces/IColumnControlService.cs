using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IColumnControlService
    {
        Task<ColumnControl> Create(ColumnControl columnControl);
        Task<ColumnControl> Update(ColumnControl columnControl);
        Task Remove(long id);
        Task<ColumnControl> Get(long id);
        Task<List<ColumnControl>> Get();
        Task<List<ColumnControl>> FindByCompany(string company);
        Task<List<string>> GetCompanies();
    }
}
