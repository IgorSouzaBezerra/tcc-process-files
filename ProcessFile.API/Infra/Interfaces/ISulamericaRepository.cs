using ProcessFile.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProcessFile.API.Infra.Interfaces
{
    public interface ISulamericaRepository : IBaseRepository<Sulamerica>
    {
        Task<List<Sulamerica>> GetAll();
        Task<Sulamerica> GetById(long id);
    }
}
