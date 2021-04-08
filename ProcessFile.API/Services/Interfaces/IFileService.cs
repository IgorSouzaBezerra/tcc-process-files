using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IFileService
    {
        Task<List<dynamic>> ReadFile(string filename, string subject);
    }
}
