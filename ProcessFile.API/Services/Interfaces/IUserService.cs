using ProcessFile.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<User> Create(User user);
        Task<User> Update(User user);
        Task Remove(long id);
        Task<User> Get(long id);
        Task<List<User>> Get();
        Task<User> FindByEmail(string email);
    }
}
