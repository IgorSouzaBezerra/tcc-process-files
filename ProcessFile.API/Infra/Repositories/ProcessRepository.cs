using Microsoft.EntityFrameworkCore;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Domain.Enum;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Repositories
{
    public class ProcessRepository : BaseRepository<Process>, IProcessRepository
    {
        private readonly ApplicationContext _context;

        public ProcessRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Process> CreateProcess(string company)
        {
            Process process = new Process
            {
                StartDate = DateTime.Now,
                Title = company
            };

            _context.Add(process);
            await _context.SaveChangesAsync();

            return process;
        }

        public async Task<Process> FindProcess(long id)
        {

            var process = await _context.Set<Process>()
                .Include(x => x.Sulamericas)
                .Include(x => x.Unimed)
                .AsNoTracking()
                .Where(x => x.Id == id)
                .ToListAsync();

            return process.FirstOrDefault();
        }

        public async Task<List<Process>> GetPending()
        {
            var process = await _context.Set<Process>()
                .AsNoTracking()
                .Where(x => x.ProcesStatus == ProcessStatus.Pending)
                .ToListAsync();

            return process;
        }
    }
}
