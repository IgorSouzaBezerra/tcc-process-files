using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProcessFile.API.Infra.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }

        public async Task<User> FindByEmail(string email)
        {
            var user = await _context.Users
                .Where(x => x.Email.ToLower() == email.ToLower())
                .AsNoTracking()
                .FirstOrDefaultAsync();

            return user;
        }
    }
}
