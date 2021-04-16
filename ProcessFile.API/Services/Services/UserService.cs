using AutoMapper;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Interfaces;
using ProcessFile.API.Providers.Interface;
using ProcessFile.API.Services.DTO;
using ProcessFile.API.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProcessFile.API.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        private readonly IHash _hash;

        public UserService(IUserRepository userRepository, IHash hash, IMapper mapper)
        {
            _userRepository = userRepository;
            _hash = hash;
            _mapper = mapper;
        }

        public async Task<UserDTO> Create(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            user.Password = _hash.GenerateHash(user.Password);
            var userCreate = await _userRepository.Create(user);
            return _mapper.Map<UserDTO>(userCreate);
        }

        public async Task<UserDTO> Get(long id)
        {
            var user = await _userRepository.Get(id);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> Get()
        {
            var users = await _userRepository.Get();
            return _mapper.Map<List<UserDTO>>(users);
        }

        public async Task Remove(long id)
        {
            await _userRepository.Remove(id);
        }

        public async Task<UserDTO> Update(UserDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            user.Password = _hash.GenerateHash(user.Password);
            var userUpdate = await _userRepository.Update(user);
            return _mapper.Map<UserDTO>(userUpdate);
        }

        public async Task<UserDTO> FindByEmail(string email)
        {
            var user = await _userRepository.FindByEmail(email);
            return _mapper.Map<UserDTO>(user);
        }
    }
}
