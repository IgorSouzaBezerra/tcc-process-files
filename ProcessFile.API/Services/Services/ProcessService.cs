using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Domain.Enum;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class ProcessService : IProcessService
    {
        private readonly IProcessRepository _processRepository;
        public ProcessService(IProcessRepository processRepository)
        {
            _processRepository = processRepository;
        }

        public async Task<Process> FindProcess(long id)
        {
            var process = await _processRepository.FindProcess(id);
            return process;
        }

        public async Task<List<Process>> Get()
        {
            var process = await _processRepository.Get();
            return process;
        }

        public async Task<Process> Get(long id)
        {
            var process = await _processRepository.Get(id);
            return process;
        }

        public async Task<List<Process>> GetPending()
        {
            var process = await _processRepository.GetPending();
            return process;
        }

        public async Task<List<Process>> GetFinished()
        {
            var process = await _processRepository.GetFinished();
            return process;
        }

        public async Task<Process> UpdateStatus(Process entity)
        {
            entity.ProcesStatus = ProcessStatus.Finished;
            var process = await _processRepository.Update(entity);
            return process;
        }
    }
}
