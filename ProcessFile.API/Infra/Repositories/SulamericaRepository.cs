using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProcessFile.API.Infra.Repositories
{
    public class SulamericaRepository : BaseRepository<Sulamerica>, ISulamericaRepository
    {
        private readonly ApplicationContext _context;

        public SulamericaRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Sulamerica>> GetAll()
        {
            var sulamerica = await _context.Set<Sulamerica>()
                .AsNoTracking()
                .Include(x => x.Process)
                .Include("Process")
                .ToListAsync();

            return sulamerica;
        }

        public async Task<Sulamerica> GetById(long id)
        {
            var sulamerica = await _context.Set<Sulamerica>()
                .AsNoTracking()
                .Include("Process")
                .ToListAsync();

            return sulamerica.FirstOrDefault();
        }
    }
}
