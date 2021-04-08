using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Interfaces
{
    public interface IProcessRepository : IBaseRepository<Process>
    {
        Task<Process> CreateProcess(string company);
        Task<Process> FindProcess(long id);
        Task<List<Process>> GetPending();
    }
}
