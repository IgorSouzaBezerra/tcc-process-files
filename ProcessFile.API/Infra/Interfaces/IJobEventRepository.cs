using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Interfaces
{
    public interface IJobEventRepository : IBaseRepository<JobEvent>
    {
        Task<JobEvent> Create();
        Task<JobEvent> CompleteJob(long id);
        Task<dynamic> GetAll(int page);
        Task<int> GetQtdJob();
    }
}
