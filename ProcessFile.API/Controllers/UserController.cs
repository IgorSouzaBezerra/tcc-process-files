﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Services.DTO;
using ProcessFile.API.Services.Interfaces;
using ProcessFile.API.ViewModel;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var users = await _userService.Get();
            return Ok(users);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUser(long id)
        {
            var user = await _userService.Get(id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserViewModel userViewModel)
        {   
            var userDTO = _mapper.Map<UserDTO>(userViewModel);
            var userCreate = await _userService.Create(userDTO);
            return Ok(userCreate);
        }
    }
}
