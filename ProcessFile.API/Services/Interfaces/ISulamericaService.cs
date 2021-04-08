using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface ISulamericaService
    {
        Task<List<Sulamerica>> GetAll();
        Task<Sulamerica> GetById(long id);
    }
}
