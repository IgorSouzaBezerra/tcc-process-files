using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class UnimedService : IUnimedService
    {
        private readonly IUnimedRepository _unimedRepository;

        public UnimedService(IUnimedRepository unimedRepository)
        {
            _unimedRepository = unimedRepository;
        }

        public async Task<List<Unimed>> Get()
        {
            var unimed = await _unimedRepository.Get();
            return unimed;
        }
    }
}
