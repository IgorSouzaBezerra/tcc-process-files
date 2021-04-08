using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace ProcessFile.API.Infra.Repositories
{
    public class ColumnControlRepository : BaseRepository<ColumnControl>, IColumnControlRepository
    {
        private readonly ApplicationContext _context;

        public ColumnControlRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<ColumnControl>> FindByCompany(string company)
        {
            var control = await _context.ColumnControls
                .Where(x => x.Company.ToLower() == company.ToLower())
                .AsNoTracking()
                .ToListAsync();

            return control;
        }

        public async Task<List<string>> GetCompanies()
        {
            var companies = await _context.ColumnControls
                .Select(x => x.Company).Distinct()
                .AsNoTracking()
                .ToListAsync();

            return companies;
        }
    }
}
