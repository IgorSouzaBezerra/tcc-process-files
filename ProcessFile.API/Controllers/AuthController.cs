using Microsoft.AspNetCore.Mvc;
using ProcessFile.API.Providers.Interface;
using ProcessFile.API.Services.Interfaces;
using ProcessFile.API.Token;
using ProcessFile.API.ViewModel;
using System.Threading.Tasks;

namespace ProcessFile.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ITokenGenerator _tokenGenerator;
        private readonly IHash _hash;
        private readonly IUserService _userService;

        public AuthController(ITokenGenerator tokenGenerator, IUserService userService, IHash hash)
        {
            _tokenGenerator = tokenGenerator;
            _userService = userService;
            _hash = hash;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] LoginViewModel login)
        {
            var user = await _userService.FindByEmail(login.Email);

            if (user == null)
            {
                return BadRequest("Email ou senha inválido.");
            }

            if (_hash.CompareHash(login.Password, user.Password))
            {
                return Ok(_tokenGenerator.GenerateToken());
            }

            return BadRequest("Email ou senha inválido.");
        }
    }
}
