using Microsoft.EntityFrameworkCore;
using ProcessFile.API.Domain;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System;
using System.Linq;
using Canducci.Pagination;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Repositories
{
    public class JobEventRepository : BaseRepository<JobEvent>, IJobEventRepository
    {
        private readonly ApplicationContext _context;

        public JobEventRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<JobEvent> Create()
        {
            JobEvent job = new JobEvent
            {
                Start = DateTime.Now.ToLocalTime(),
                JobStatus = JobStatus.Running
            };

            _context.Add(job);
            await _context.SaveChangesAsync();

            return job;
        }

        public async Task<JobEvent> CompleteJob(long id)
        {
            var job = await Get(id);

            job.End = DateTime.Now.ToLocalTime();
            job.JobStatus = JobStatus.Finished;

            _context.Entry(job).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return job;
        }

        public async Task<dynamic> GetAll(int page)
        {
            var jobs = await _context.JobEvents
                .AsNoTracking()
                .OrderByDescending(o => o.Start)
                .ToPaginatedRestAsync(page, 15);
            return jobs;
        }
    }
}
