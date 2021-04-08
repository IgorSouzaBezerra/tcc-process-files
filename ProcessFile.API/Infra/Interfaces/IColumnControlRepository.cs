using ProcessFile.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Interfaces
{
    public interface IColumnControlRepository : IBaseRepository<ColumnControl>
    {
        Task<List<ColumnControl>> FindByCompany(string company);
        Task<List<string>> GetCompanies();
    }
}
