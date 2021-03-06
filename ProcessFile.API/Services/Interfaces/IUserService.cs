using ProcessFile.API.Services.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDTO> Create(UserDTO userDTO);
        Task<UserDTO> Update(UserDTO userDTO);
        Task Remove(long id);
        Task<UserDTO> Get(long id);
        Task<List<UserDTO>> Get();
        Task<UserDTO> FindByEmail(string email);
    }
}
