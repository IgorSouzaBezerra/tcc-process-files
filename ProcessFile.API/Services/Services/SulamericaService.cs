using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class SulamericaService : ISulamericaService
    {
        private readonly ISulamericaRepository _sulamericaRepository;

        public SulamericaService(ISulamericaRepository sulamericaRepository)
        {
            _sulamericaRepository = sulamericaRepository;
        }

        public async Task<Sulamerica> GetById(long id)
        {
            var sulamerica = await _sulamericaRepository.GetById(id);
            return sulamerica;
        }

        public async Task<List<Sulamerica>> GetAll()
        {
            return await _sulamericaRepository.GetAll();
        }
    }
}
