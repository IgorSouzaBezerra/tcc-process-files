using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class JobEventService : IJobEventService
    {
        private readonly IJobEventRepository _jobRepository;

        public JobEventService(IJobEventRepository jobRepository)
        {
            _jobRepository = jobRepository;
        }

        public async Task<JobEvent> Create()
        {
            var job = await _jobRepository.Create();
            return job;
        }

        public async Task<JobEvent> CompleteJob(long id)
        {
            var job = await _jobRepository.CompleteJob(id);
            return job;
        }

        public async Task<List<JobEvent>> Get()
        {
            var jobs = await _jobRepository.Get();
            return jobs;
        }

        public async Task<JobEvent> Get(long id)
        {
            var job = await _jobRepository.Get(id);
            return  job;
        }

        public async Task<dynamic> GetAll(int page)
        {
            var jobs = await _jobRepository.GetAll(page);
            return jobs;
        }

        public async Task<int> GetQtdJob()
        {
            var jobs = await _jobRepository.GetQtdJob();
            return jobs;
        }
    }
}
