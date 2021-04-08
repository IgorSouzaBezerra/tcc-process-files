using ProcessFile.API.Domain.Entities;
using ProcessFile.API.Infra.Context;
using ProcessFile.API.Infra.Interfaces;

namespace ProcessFile.API.Infra.Repositories
{
    public class UnimedRepository : BaseRepository<Unimed>, IUnimedRepository
    {
        private readonly ApplicationContext _context;

        public UnimedRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
