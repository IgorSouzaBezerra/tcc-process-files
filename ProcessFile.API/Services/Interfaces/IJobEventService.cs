using System.Collections.Generic;
using System.Threading.Tasks;
using ProcessFile.API.Domain.Entities;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IJobEventService
    {
        Task<JobEvent> Create();
        Task<JobEvent> CompleteJob(long id);
        Task<List<JobEvent>> Get();
        Task<JobEvent> Get(long id);
        Task<dynamic> GetAll(int page);
        Task<int> GetQtdJob();
    }
}
