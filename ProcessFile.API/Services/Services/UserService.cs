using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Providers.Interface;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IHash _hash;

        public UserService(IUserRepository userRepository, IHash hash)
        {
            _userRepository = userRepository;
            _hash = hash;
        }

        public async Task<User> Create(User user)
        {
            user.Password = _hash.GenerateHash(user.Password);
            var userCreate = await _userRepository.Create(user);
            return userCreate;
        }

        public async Task<User> Get(long id)
        {
            var user = await _userRepository.Get(id);
            return user;
        }

        public async Task<List<User>> Get()
        {
            var users = await _userRepository.Get();
            return users;
        }

        public async Task Remove(long id)
        {
            await _userRepository.Remove(id);
        }

        public async Task<User> Update(User user)
        {
            var userUpdate = await _userRepository.Update(user);
            return userUpdate;
        }

        public async Task<User> FindByEmail(string email)
        {
            var user = await _userRepository.FindByEmail(email);
            return user;
        }
    }
}
