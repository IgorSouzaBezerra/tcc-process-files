using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IProcessService
    {
        Task<List<Process>> Get();
        Task<Process> FindProcess(long id);
        Task<Process> Get(long id);
        Task<Process> UpdateStatus(Process entity);
        Task<List<Process>> GetPending();
        Task<List<Process>> GetFinished();
    }
}
